using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StocksAndFinance.Classes;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace StocksAndFinance.CustomControls
{
    public partial class StockControl : UserControl
    {
        User user;
        public StockControl()
        {
            user = Users.currentUser;
            InitializeComponent();
            Load  += Stocks_Load;
        }

        private void Stocks_Load(object sender, EventArgs e)
        {

            Debug.WriteLine("the symbol is :::::: " + user.Stocks[0].Symbol);

            setGraph(user.Stocks[0].Symbol);
            setComboBox();
            
            this.txtShares.Text = GetStockCount();
        }
        private string GetStockCount()
        {
            string stockCount = user.Stocks.Find(Stock => Stock.Symbol == cmbStocks.Text).Shares.ToString();
            Debug.WriteLine("STOCK COUNT : "+stockCount);
            return stockCount;
        }
        private void setGraph(string Symbol)
        {
            //reset and set stock to symbol passed
            crtStocks.Series.Clear();
            crtStocks.Series.Add(Symbol);
            crtStocks.Series[Symbol].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            crtStocks.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;

            //get stock from user that matches the symbol.
            Stock stock = user.Stocks.Find(userStock => userStock.Symbol == Symbol);

            //after user class is done with api call and data is set, get history
            List<StockHistory> history = stock.History;


            for(int i = 0; i < history.Count; i++)
            {
                DateTime day = history[i].Date;
                crtStocks.Series[stock.Symbol].Points.AddXY(day, history[i].Price);
            }
        }

        private void setComboBox()
        {
            //clear list.
            cmbStocks.Items.Clear();
            //set inital value
            cmbStocks.Text = user.Stocks[0].Symbol;
            //add combo items
            foreach (Stock stock in user.Stocks)
            {
                cmbStocks.Items.Add(stock.Symbol);
            }

        }

        private void btnChangeShare_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(txtShares.Text, out int sharesNumber))
            {
                DbHandler.ChangeStockCount(Users.currentUser.UserId, cmbStocks.Text, sharesNumber);
                Users.currentUser.Stocks.Find(stock => stock.Symbol == cmbStocks.Text).Shares = sharesNumber;
            }
        }

        private void cmbStocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("KJHDFSKHJDSFHKLJDSFHKJL");
            ComboBox comboStock = (ComboBox)sender;
            //change Graph
            setGraph(comboStock.Text);
            this.txtShares.Text = GetStockCount();

        }

        private void StockControl_Load(object sender, EventArgs e)
        {

        }

        private async void btnAddStock_Click(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;
            //disable this button until api call is complete.
            thisButton.Enabled = false;
            //if valid, add to database.
            bool validInput = await ValidateEntries();
            if (validInput)
            {
                Debug.WriteLine("Adding the stocks");
                DbHandler.AddStock(Users.currentUser.UserId,txtSymbol.Text, Int32.Parse(txtAddShares.Text));
            }
            //Reset current user's Stock List
            Users.currentUser.setStock();
            //wait for stocks to be set.
            while(Users.currentUser.Stocks is null)
            {
                await Task.Delay(100);
            }


            //Reset comboBox with all values
            setComboBox();
            //allow button to be pressed again.
            thisButton.Enabled = true;
        }
        private async Task<bool> ValidateEntries()
        {
            Debug.WriteLine("Validating..");
            //check if stock is already in the user's list, 
            foreach (Stock stock in Users.currentUser.Stocks)
            {
                if (stock.Symbol == txtSymbol.Text)
                {
                    Debug.WriteLine("Failed at Stock Already in User list");
                    return false;
                }
            }
            Debug.WriteLine("Checking API");
            //check that the symbol return a value from the api call.

            if (!await ApiHandler.CheckValidCall(txtSymbol.Text))
            {
                Debug.WriteLine("Failed at API Didn't returun result");
                return false;
            }
            //check if the txt.shares is set with numbers
            if(!Int32.TryParse(txtAddShares.Text, out int shareNumbers))
            {
                Debug.WriteLine("Failed at shareNumber isn't a number");
                return false;
            }
            Debug.WriteLine("didn't fail");
            return true;
        }
    }
}
