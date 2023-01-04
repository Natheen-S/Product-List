using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Product_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtbox_product_id1_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtbox_product_name1.IsReadOnly= true;
            txtbox_product_price1.IsReadOnly=true;
            txtbox_total_price1.IsReadOnly=true;
        }

        private void txtbox_product_id2_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtbox_product_name2.IsReadOnly = true;
            txtbox_product_price2.IsReadOnly = true;
            txtbox_total_price2.IsReadOnly = true;

            
        }

        private void txtbox_product_id3_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtbox_product_name3.IsReadOnly = true;
            txtbox_product_price3.IsReadOnly = true;
            txtbox_total_price3.IsReadOnly = true;
        }

        private void txtbox_product_id4_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtbox_product_name4.IsReadOnly = true;
            txtbox_product_price4.IsReadOnly = true;
            txtbox_total_price4.IsReadOnly = true;
        }

        private void txtbox_product_id5_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtbox_product_name5.IsReadOnly = true;
            txtbox_product_price5.IsReadOnly = true;
            txtbox_total_price5.IsReadOnly = true;
        }

        private void txtbox_product_id6_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtbox_product_name6.IsReadOnly = true;
            txtbox_product_price6.IsReadOnly = true;
            txtbox_total_price6.IsReadOnly = true;
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox_product_id1.Text == "a1")
            {
                A1product();
            }
            if (txtbox_product_id1.Text == "a2")
            {
                B1product();
            }
            if (txtbox_product_id1.Text == "a3")
            {
                C1product();
            }
            if (txtbox_product_id1.Text == "a4")
            {
                D1product();
            }
            if (txtbox_product_id1.Text == "a5")
            {
                E1product();
            }
            if (txtbox_product_id2.Text == "a6")
            {
                F1product();
            }
            if (txtbox_product_id2.Text == "a1")
            {
                A2product();
            }
            if (txtbox_product_id2.Text == "a2")
            {
                B2product();
            }
            if (txtbox_product_id2.Text == "a3")
            {
                C2product();
            }
            if (txtbox_product_id2.Text == "a4")
            {
                D2product();
            }
            if (txtbox_product_id2.Text == "a5")
            {
                E2product();
            }
            if (txtbox_product_id2.Text == "a6")
            {
                F2product();
            }
            if (txtbox_product_id3.Text == "a1")
            {
                A3product();
            }
            if (txtbox_product_id3.Text == "a2")
            {
                B3product();
            }
            if (txtbox_product_id3.Text == "a3")
            {
                C3product();
            }
            if (txtbox_product_id3.Text == "a4")
            {
                D3product();
            }
            if (txtbox_product_id3.Text == "a5")
            {
                E3product();
            }
            if (txtbox_product_id3.Text == "a6")
            {
                F3product();
            }
            if (txtbox_product_id4.Text == "a1")
            {
                A4product();
            }
            if (txtbox_product_id4.Text == "a2")
            {
                B4product();
            }   
            if (txtbox_product_id4.Text == "a3")
            {
                C4product();
            }
            if (txtbox_product_id4.Text == "a4")
            {
                D4product();
            }
            if (txtbox_product_id4.Text == "a5")
            {
                E4product();
            }
            if (txtbox_product_id4.Text == "a6")
            {
                F4product();
            }
            if (txtbox_product_id5.Text == "a1")
            {
                A5product();
            }
            if (txtbox_product_id5.Text == "a2")
            {
                B5product();
            }
            if (txtbox_product_id5.Text == "a3")
            {
                C5product();
            }
            if (txtbox_product_id5.Text == "a4")
            {
                D5product();
            }
            if (txtbox_product_id5.Text == "a5")
            {
                E5product();
            }
            if (txtbox_product_id5.Text == "a6")
            {
                F5product();
            }
            if (txtbox_product_id6.Text == "a1")
            {
                A6product();
            }
            if (txtbox_product_id6.Text == "a2")
            {
                B6product();
            }
            if (txtbox_product_id6.Text == "a3")
            {
                C6product();
            }
            if (txtbox_product_id6.Text == "a4")
            {
                D6product();
            }
            if (txtbox_product_id6.Text == "a5")
            {
                E6product();
            }
            if (txtbox_product_id6.Text == "a6")
            {
                F6product();
            }

        }

        private int A1product()
        {
            txtbox_product_name1.Text = "MacBook Air M1";
            txtbox_product_price1.Text = "89,990";

            int quantity = Convert.ToInt32(txtbox_quantity1.Text);
            int product_price = 89990 * quantity;
            

            int discount = Convert.ToInt32(txtbox_discount1.Text);
            int total_price = product_price - discount;
            txtbox_total_price1.Text = total_price.ToString();

            return 0;
        }
        private int B1product()
        {
            
            txtbox_product_name1.Text = "Ipad Pro M1";
            txtbox_product_price1.Text = "49,990";

            int quantity = Convert.ToInt32(txtbox_quantity1.Text);
            int product_price = 49990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount1.Text);
            int total_price = product_price - discount;
            txtbox_total_price1.Text = total_price.ToString();

            return 0;
        }
        private int C1product()
        {
            txtbox_product_name1.Text = "Iphone 14 Pro ";
            txtbox_product_price1.Text = "1,49,990";

            int quantity = Convert.ToInt32(txtbox_quantity1.Text);
            int product_price = 149990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount1.Text);
            int total_price = product_price - discount;
            txtbox_total_price1.Text = total_price.ToString();

            return 0;
        }
        private int D1product()
        {
            txtbox_product_name1.Text = "Iphone 14 Pro Max";
            txtbox_product_price1.Text = "1,89,990";

            int quantity = Convert.ToInt32(txtbox_quantity1.Text);
            int product_price = 189990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount1.Text);
            int total_price = product_price - discount;
            txtbox_total_price1.Text = total_price.ToString();

            return 0;
        }
        private int E1product()
        {
            txtbox_product_name1.Text = "Iphone 14";
            txtbox_product_price1.Text = "79,990";

            int quantity = Convert.ToInt32(txtbox_quantity1.Text);
            int product_price = 79990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount1.Text);
            int total_price = product_price - discount;
            txtbox_total_price1.Text = total_price.ToString();

            return 0;
        }
        private int F1product()
        {
            txtbox_product_name1.Text = "Apple Iwatch Ultra";
            txtbox_product_price1.Text = "89,990";

            int quantity = Convert.ToInt32(txtbox_quantity1.Text);
            int product_price = 89990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount1.Text);
            int total_price = product_price - discount;
            txtbox_total_price1.Text = total_price.ToString();

            return 0;
        }
        private int A2product()
        {
            txtbox_product_name2.Text = "MacBook Air M1";
            txtbox_product_price2.Text = "89,990";

            int quantity = Convert.ToInt32(txtbox_quantity2.Text);
            int product_price = 89990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount2.Text);
            int total_price = product_price - discount;
            txtbox_total_price2.Text = total_price.ToString();

            return 0;
        }
        private int B2product()
        {

            txtbox_product_name2.Text = "Ipad Pro M1";
            txtbox_product_price2.Text = "49,990";

            int quantity = Convert.ToInt32(txtbox_quantity2.Text);
            int product_price = 49990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount2.Text);
            int total_price = product_price - discount;
            txtbox_total_price2.Text = total_price.ToString();

            return 0;
        }
        private int C2product()
        {
            txtbox_product_name2.Text = "Iphone 14 Pro ";
            txtbox_product_price2.Text = "1,49,990";

            int quantity = Convert.ToInt32(txtbox_quantity2.Text);
            int product_price = 149990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount2.Text);
            int total_price = product_price - discount;
            txtbox_total_price2.Text = total_price.ToString();

            return 0;
        }
        private int D2product()
        {
            txtbox_product_name2.Text = "Iphone 14 Pro Max";
            txtbox_product_price2.Text = "1,89,990";

            int quantity = Convert.ToInt32(txtbox_quantity2.Text);
            int product_price = 189990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount2.Text);
            int total_price = product_price - discount;
            txtbox_total_price2.Text = total_price.ToString();

            return 0;
        }
        private int E2product()
        {
            txtbox_product_name2.Text = "Iphone 14";
            txtbox_product_price2.Text = "79,990";

            int quantity = Convert.ToInt32(txtbox_quantity2.Text);
            int product_price = 79990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount2.Text);
            int total_price = product_price - discount;
            txtbox_total_price2.Text = total_price.ToString();

            return 0;
        }
        private int F2product()
        {
            txtbox_product_name2.Text = "Apple Iwatch Ultra";
            txtbox_product_price2.Text = "89,990";

            int quantity = Convert.ToInt32(txtbox_quantity2.Text);
            int product_price = 89990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount2.Text);
            int total_price = product_price - discount;
            txtbox_total_price2.Text = total_price.ToString();

            return 0;
        }
        private int A3product()
        {
            txtbox_product_name3.Text = "MacBook Air M1";
            txtbox_product_price3.Text = "89,990";

            int quantity = Convert.ToInt32(txtbox_quantity3.Text);
            int product_price = 89990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount3.Text);
            int total_price = product_price - discount;
            txtbox_total_price3.Text = total_price.ToString();

            return 0;
        }
        private int B3product()
        {

            txtbox_product_name3.Text = "Ipad Pro M1";
            txtbox_product_price3.Text = "49,990";

            int quantity = Convert.ToInt32(txtbox_quantity3.Text);
            int product_price = 49990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount3.Text);
            int total_price = product_price - discount;
            txtbox_total_price3.Text = total_price.ToString();

            return 0;
        }
        private int C3product()
        {
            txtbox_product_name3.Text = "Iphone 14 Pro ";
            txtbox_product_price3.Text = "1,49,990";

            int quantity = Convert.ToInt32(txtbox_quantity3.Text);
            int product_price = 149990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount3.Text);
            int total_price = product_price - discount;
            txtbox_total_price3.Text = total_price.ToString();

            return 0;
        }
        private int D3product()
        {
            txtbox_product_name3.Text = "Iphone 14 Pro Max";
            txtbox_product_price3.Text = "1,89,990";

            int quantity = Convert.ToInt32(txtbox_quantity3.Text);
            int product_price = 189990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount3.Text);
            int total_price = product_price - discount;
            txtbox_total_price3.Text = total_price.ToString();

            return 0;
        }
        private int E3product()
        {
            txtbox_product_name3.Text = "Iphone 14";
            txtbox_product_price3.Text = "79,990";

            int quantity = Convert.ToInt32(txtbox_quantity3.Text);
            int product_price = 79990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount3.Text);
            int total_price = product_price - discount;
            txtbox_total_price3.Text = total_price.ToString();

            return 0;
        }
        private int F3product()
        {
            txtbox_product_name3.Text = "Apple Iwatch Ultra";
            txtbox_product_price3.Text = "89,990";

            int quantity = Convert.ToInt32(txtbox_quantity3.Text);
            int product_price = 89990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount3.Text);
            int total_price = product_price - discount;
            txtbox_total_price3.Text = total_price.ToString();

            return 0;
        }
        private int A4product()
        {
            txtbox_product_name4.Text = "MacBook Air M1";
            txtbox_product_price4.Text = "89,990";

            int quantity = Convert.ToInt32(txtbox_quantity4.Text);
            int product_price = 89990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount4.Text);
            int total_price = product_price - discount;
            txtbox_total_price4.Text = total_price.ToString();

            return 0;
        }
        private int B4product()
        {

            txtbox_product_name4.Text = "Ipad Pro M1";
            txtbox_product_price4.Text = "49,990";

            int quantity = Convert.ToInt32(txtbox_quantity4.Text);
            int product_price = 49990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount4.Text);
            int total_price = product_price - discount;
            txtbox_total_price4.Text = total_price.ToString();

            return 0;
        }
        private int C4product()
        {
            txtbox_product_name4.Text = "Iphone 14 Pro ";
            txtbox_product_price4.Text = "1,49,990";

            int quantity = Convert.ToInt32(txtbox_quantity4.Text);
            int product_price = 149990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount4.Text);
            int total_price = product_price - discount;
            txtbox_total_price4.Text = total_price.ToString();

            return 0;
        }
        private int D4product()
        {
            txtbox_product_name4.Text = "Iphone 14 Pro Max";
            txtbox_product_price4.Text = "1,89,990";

            int quantity = Convert.ToInt32(txtbox_quantity4.Text);
            int product_price = 189990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount4.Text);
            int total_price = product_price - discount;
            txtbox_total_price4.Text = total_price.ToString();

            return 0;
        }
        private int E4product()
        {
            txtbox_product_name4.Text = "Iphone 14";
            txtbox_product_price4.Text = "79,990";

            int quantity = Convert.ToInt32(txtbox_quantity4.Text);
            int product_price = 79990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount4.Text);
            int total_price = product_price - discount;
            txtbox_total_price4.Text = total_price.ToString();

            return 0;
        }
        private int F4product()
        {
            txtbox_product_name4.Text = "Apple Iwatch Ultra";
            txtbox_product_price4.Text = "89,990";

            int quantity = Convert.ToInt32(txtbox_quantity4.Text);
            int product_price = 89990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount4.Text);
            int total_price = product_price - discount;
            txtbox_total_price4.Text = total_price.ToString();

            return 0;
        }
        private int A5product()
        {
            txtbox_product_name5.Text = "MacBook Air M1";
            txtbox_product_price5.Text = "89,990";

            int quantity = Convert.ToInt32(txtbox_quantity5.Text);
            int product_price = 89990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount5.Text);
            int total_price = product_price - discount;
            txtbox_total_price5.Text = total_price.ToString();

            return 0;
        }
        private int B5product()
        {

            txtbox_product_name5.Text = "Ipad Pro M1";
            txtbox_product_price5.Text = "49,990";

            int quantity = Convert.ToInt32(txtbox_quantity5.Text);
            int product_price = 49990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount5.Text);
            int total_price = product_price - discount;
            txtbox_total_price5.Text = total_price.ToString();

            return 0;
        }
        private int C5product()
        {
            txtbox_product_name5.Text = "Iphone 14 Pro ";
            txtbox_product_price5.Text = "1,49,990";

            int quantity = Convert.ToInt32(txtbox_quantity5.Text);
            int product_price = 149990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount5.Text);
            int total_price = product_price - discount;
            txtbox_total_price5.Text = total_price.ToString();

            return 0;
        }
        private int D5product()
        {
            txtbox_product_name5.Text = "Iphone 14 Pro Max";
            txtbox_product_price5.Text = "1,89,990";

            int quantity = Convert.ToInt32(txtbox_quantity5.Text);
            int product_price = 189990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount5.Text);
            int total_price = product_price - discount;
            txtbox_total_price5.Text = total_price.ToString();

            return 0;
        }
        private int E5product()
        {
            txtbox_product_name5.Text = "Iphone 14";
            txtbox_product_price5.Text = "79,990";

            int quantity = Convert.ToInt32(txtbox_quantity5.Text);
            int product_price = 79990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount5.Text);
            int total_price = product_price - discount;
            txtbox_total_price5.Text = total_price.ToString();

            return 0;
        }
        private int F5product()
        {
            txtbox_product_name5.Text = "Apple Iwatch Ultra";
            txtbox_product_price5.Text = "89,990";

            int quantity = Convert.ToInt32(txtbox_quantity5.Text);
            int product_price = 89990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount5.Text);
            int total_price = product_price - discount;
            txtbox_total_price5.Text = total_price.ToString();

            return 0;
        }
        private int A6product()
        {
            txtbox_product_name6.Text = "MacBook Air M1";
            txtbox_product_price6.Text = "89,990";

            int quantity = Convert.ToInt32(txtbox_quantity6.Text);
            int product_price = 89990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount6.Text);
            int total_price = product_price - discount;
            txtbox_total_price6.Text = total_price.ToString();

            return 0;
        }
        private int B6product()
        {

            txtbox_product_name6.Text = "Ipad Pro M1";
            txtbox_product_price6.Text = "49,990";

            int quantity = Convert.ToInt32(txtbox_quantity6.Text);
            int product_price = 49990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount6.Text);
            int total_price = product_price - discount;
            txtbox_total_price6.Text = total_price.ToString();

            return 0;
        }
        private int C6product()
        {
            txtbox_product_name6.Text = "Iphone 14 Pro ";
            txtbox_product_price6.Text = "1,49,990";

            int quantity = Convert.ToInt32(txtbox_quantity6.Text);
            int product_price = 149990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount6.Text);
            int total_price = product_price - discount;
            txtbox_total_price6.Text = total_price.ToString();

            return 0;
        }
        private int D6product()
        {
            txtbox_product_name6.Text = "Iphone 14 Pro Max";
            txtbox_product_price6.Text = "1,89,990";

            int quantity = Convert.ToInt32(txtbox_quantity6.Text);
            int product_price = 189990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount6.Text);
            int total_price = product_price - discount;
            txtbox_total_price6.Text = total_price.ToString();

            return 0;
        }
        private int E6product()
        {
            txtbox_product_name6.Text = "Iphone 14";
            txtbox_product_price6.Text = "79,990";

            int quantity = Convert.ToInt32(txtbox_quantity6.Text);
            int product_price = 79990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount6.Text);
            int total_price = product_price - discount;
            txtbox_total_price6.Text = total_price.ToString();

            return 0;
        }
        private int F6product()
        {
            txtbox_product_name6.Text = "Apple Iwatch Ultra";
            txtbox_product_price6.Text = "89,990";

            int quantity = Convert.ToInt32(txtbox_quantity6.Text);
            int product_price = 89990 * quantity;


            int discount = Convert.ToInt32(txtbox_discount6.Text);
            int total_price = product_price - discount;
            txtbox_total_price6.Text = total_price.ToString();

            return 0;
        }
    }
}
