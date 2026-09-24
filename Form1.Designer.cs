namespace MenuApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.ListBox lstSelected;
        private System.Windows.Forms.Button btnAdd;    // >
        private System.Windows.Forms.Button btnRemove; // <
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Label lblSelectedTitle;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.lstSelected = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.lblSelectedTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblMenuTitle
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Location = new System.Drawing.Point(20, 15);
            this.lblMenuTitle.Text = "Danh sách món ăn";

            // lstMenu
            this.lstMenu.Location = new System.Drawing.Point(20, 40);
            this.lstMenu.Size = new System.Drawing.Size(180, 160);

            // btnAdd (>)
            this.btnAdd.Location = new System.Drawing.Point(215, 70);
            this.btnAdd.Size = new System.Drawing.Size(50, 35);
            this.btnAdd.Text = ">";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnRemove (<)
            this.btnRemove.Location = new System.Drawing.Point(215, 115);
            this.btnRemove.Size = new System.Drawing.Size(50, 35);
            this.btnRemove.Text = "<";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // lblSelectedTitle
            this.lblSelectedTitle.AutoSize = true;
            this.lblSelectedTitle.Location = new System.Drawing.Point(280, 15);
            this.lblSelectedTitle.Text = "Món đã chọn";

            // lstSelected
            this.lstSelected.Location = new System.Drawing.Point(280, 40);
            this.lstSelected.Size = new System.Drawing.Size(180, 160);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(280, 210);
            this.lblTotal.Text = "Tổng tiền: 0đ";

            // Form1
            this.ClientSize = new System.Drawing.Size(490, 250);
            this.Controls.Add(this.lblMenuTitle);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblSelectedTitle);
            this.Controls.Add(this.lstSelected);
            this.Controls.Add(this.lblTotal);
            this.Text = "Quản lý gọi món";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}