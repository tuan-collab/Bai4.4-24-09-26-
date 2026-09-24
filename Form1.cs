using System;
using System.Windows.Forms;

namespace MenuApp
{
    // Lớp đại diện cho 1 món ăn, override ToString() để hiển thị đẹp trong ListBox
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:N0}đ";
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadMenu();
        }

        // Nạp danh sách món ăn sẵn có vào lstMenu
        private void LoadMenu()
        {
            lstMenu.Items.Add(new MenuItem("Hamburger", 50000));
            lstMenu.Items.Add(new MenuItem("Pizza", 120000));
            lstMenu.Items.Add(new MenuItem("Gà Rán", 35000));
            lstMenu.Items.Add(new MenuItem("Pepsi", 15000));
        }

        // Nút > : chuyển món đang chọn từ lstMenu sang lstSelected
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MenuItem selected = (MenuItem)lstMenu.SelectedItem;
            lstSelected.Items.Add(selected);

            UpdateTotal();
        }

        // Nút < : xóa món đang chọn khỏi lstSelected
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstSelected.Items.Remove(lstSelected.SelectedItem);

            UpdateTotal();
        }

        // Tính lại tổng tiền mỗi khi lstSelected thay đổi
        private void UpdateTotal()
        {
            double total = 0;

            foreach (object item in lstSelected.Items)
            {
                MenuItem menuItem = (MenuItem)item;
                total += menuItem.Price;
            }

            lblTotal.Text = $"Tổng tiền: {total:N0}đ";
        }
    }
}