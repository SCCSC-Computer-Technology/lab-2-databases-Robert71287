using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_databases_RobertZheng
{
    public partial class Lab2RobertZheng : Form
    {
        public Lab2RobertZheng()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void PopulationAsc_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByPopASC(cityDBDataSet.City);
        }

        private void popDesc_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByPopDesc(cityDBDataSet.City);

        }

        private void cityname_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByCityAsc(cityDBDataSet.City);

        }

        private void SumPop_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillBySumPop(cityDBDataSet.City);

        }

        private void AveragePop_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByAvgPop(cityDBDataSet.City);

        }

        private void highestPopulation_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByMaxPop(cityDBDataSet.City);

        }

        private void lowestPopulation_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByMinPop(cityDBDataSet.City);

        }
    }
}
