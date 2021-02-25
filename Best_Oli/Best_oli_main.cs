using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Best_Oli
{
    public partial class Best_Oli : Form
    {


        public Best_Oli()
        {
            products_gass = new List<Product>();
            products_gass.AddRange(new Product[] { new Product("АИ - 92",24.3),
            new Product("АИ - 95",28.7),new Product("АИ - 98",32.1)
            });

            InitializeComponent();
            price_cola.Text = "20,5";
            price_G.Text = "55,9";
            price_potato.Text = "23,4";
            price_hot.Text = "28,3";

            products_gass.ForEach(i => gass_panel_box.Items.Add(i.name));
            gass_panel_box.SelectedIndex = 0;
            price.Text = products_gass.Find(i => i.name == (gass_panel_box.SelectedItem.ToString())).price.ToString();
            rb_sum.CheckedChanged += rb_CheckedChanged;
            rb_count.CheckedChanged += rb_CheckedChanged;
            gass_panel_box.SelectionChangeCommitted += Gass_panel_box_SelectionChangeCommitted;
            butt_rezult.Click += Butt_rezult_Click;
            hot_dog.CheckedChanged += CheckedChanged;
            kola.CheckedChanged += CheckedChanged;
            potato.CheckedChanged += CheckedChanged;
            gamburger.CheckedChanged += CheckedChanged;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                switch ((sender as CheckBox).Text)
                {
                    case "Хот-Дог":
                        numeric_hot.Value++;
                        break;
                    case "Гамбургер":
                        numeric_G.Value++;
                        break;
                    case "Картошка фри":
                        numeric_potato.Value++;
                        break;
                    case "Кола":
                        numeric_cola.Value++;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch ((sender as CheckBox).Text)
                {
                    case "Хот-Дог":
                        numeric_hot.Value=numeric_hot.Minimum ;
                        break;
                    case "Гамбургер":
                        numeric_G.Value= numeric_G.Minimum;
                        break;
                    case "Картошка фри":
                        numeric_potato.Value= numeric_potato.Minimum;
                        break;
                    case "Кола":
                        numeric_cola.Value= numeric_cola.Minimum;
                        break;
                    default:
                        break;

                }
            }
           
        }

        private void Butt_rezult_Click(object sender, EventArgs e)
        {
            double temp_gass;
            if (rb_count.Checked)
            {
                temp_gass = (Double.Parse(price.Text) * Double.Parse(cout_litrs.Text));
                gass_panel_rezult_mony.Text = temp_gass.ToString();
            }
            else
            {
                if (cout_mony.Text != "")
                {
                    cout_litrs.Text = (Double.Parse(cout_mony.Text) / Double.Parse(price.Text)).ToString();
                    temp_gass = Double.Parse(cout_mony.Text);
                    gass_panel_rezult_mony.Text = temp_gass.ToString();
                }
                else
                { temp_gass = 0; gass_panel_rezult_mony.Text = "0"; }
            }
            double temp_cafe = 0;// Double.Parse(cafe_panel_rezult_mony.Text);
            if (hot_dog.Checked)
            {
                temp_cafe += Double.Parse(price_hot.Text) * Convert.ToInt32(numeric_hot.Value);
            }
            if(gamburger.Checked)
            {
                temp_cafe += Double.Parse(price_G.Text)* Convert.ToInt32(numeric_G.Value);
            }
            if (potato.Checked)
            {
                temp_cafe += Double.Parse(price_potato.Text)*Convert.ToInt32(numeric_potato.Value);
            }
            if (kola.Checked)
            {
                temp_cafe += Double.Parse(price_cola.Text)*Convert.ToInt32(numeric_cola.Value);
            }
            cafe_panel_rezult_mony.Text = temp_cafe.ToString();
            rezult_price.Text = (temp_cafe + temp_gass).ToString();
        }



        // ComboBox event
        private void Gass_panel_box_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            price.Text = products_gass.Find(i => i.name == ((sender as ComboBox).SelectedItem.ToString())).price.ToString();
            
        }

        // event radio butt
        private void rb_CheckedChanged(object sender, System.EventArgs e)
        {
            if ((sender as RadioButton).Name == "rb_count")
            {
                cout_mony.Enabled = false;
                cout_litrs.Enabled = true;
            }
            else
            {
                cout_mony.Enabled = true;
                cout_litrs.Enabled = false;
            }          
        }
        private Panel panel_cafe;
        private Panel panel2;
        private Label cafe_panel_rezult_txt;
        private Label label2;
        private Label cafe_panel_rezult_mony;
        private Label cafe_panel_name;
        private CheckBox hot_dog;
        private CheckBox kola;
        private CheckBox potato;
        private CheckBox gamburger;
        private Label cafe_panel_count;
        private Label cafe_panel_price;
        private NumericUpDown numeric_G;
        private NumericUpDown numeric_potato;
        private NumericUpDown numeric_cola;
        private NumericUpDown numeric_hot;
        private Label price_G;
        private Label price_potato;
        private Label price_cola;
        private Label price_hot;
        private Panel rezult_panel;
        private Label label3;
        private Label rezult_price;
        private Label label1;
        private Button butt_rezult;

        private Panel panel_gass;
        private Label gass_panel_name;
        private Label gass_panel_name_box;
        private ComboBox gass_panel_box;
        private Label gass_lable_grn2;
        private Label price;
        private TextBox cout_mony;
        private TextBox cout_litrs;
        private Label gass_lable_grn;
        private Panel gass_panel_radio;
        private RadioButton rb_sum;
        private RadioButton rb_count;
        private Label gass_panel_price;
        private Panel gass_panel_rezult;
        private Label gass_panel_rezult_txt;
        private Label gass_lable_grn3;
        private Label gass_panel_rezult_mony;
        private Label gass_lable_l;
        List<Product> products_gass;


    }
}
