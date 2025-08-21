namespace fast_food_system_desktop_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            homeFlowLayoutPanel = new FlowLayoutPanel();
            cartFlowLayoutPanel = new FlowLayoutPanel();
            cartButton = new Button();
            homeButton = new Button();
            dineInRadioButton = new RadioButton();
            pickUpRadioButton = new RadioButton();
            deliveryRadioButton = new RadioButton();
            infoGroupBox = new GroupBox();
            ordersFlowLayoutPanel = new FlowLayoutPanel();
            ordersButton = new Button();
            clearCartButton = new Button();
            formPanel = new Panel();
            placeOrderButton = new Button();
            infoGroupBox.SuspendLayout();
            formPanel.SuspendLayout();
            SuspendLayout();
            // 
            // homeFlowLayoutPanel
            // 
            homeFlowLayoutPanel.Location = new Point(12, 109);
            homeFlowLayoutPanel.Name = "homeFlowLayoutPanel";
            homeFlowLayoutPanel.Size = new Size(720, 600);
            homeFlowLayoutPanel.TabIndex = 0;
            // 
            // cartFlowLayoutPanel
            // 
            cartFlowLayoutPanel.Location = new Point(12, 109);
            cartFlowLayoutPanel.Name = "cartFlowLayoutPanel";
            cartFlowLayoutPanel.Size = new Size(720, 600);
            cartFlowLayoutPanel.TabIndex = 1;
            // 
            // cartButton
            // 
            cartButton.Location = new Point(894, 68);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(100, 50);
            cartButton.TabIndex = 2;
            cartButton.Text = "Cart";
            cartButton.UseVisualStyleBackColor = true;
            cartButton.Click += ShowCartPanel;
            // 
            // homeButton
            // 
            homeButton.Location = new Point(894, 12);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(100, 50);
            homeButton.TabIndex = 3;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += ShowHomePanel;
            // 
            // dineInRadioButton
            // 
            dineInRadioButton.AutoSize = true;
            dineInRadioButton.Location = new Point(6, 26);
            dineInRadioButton.Name = "dineInRadioButton";
            dineInRadioButton.Size = new Size(73, 24);
            dineInRadioButton.TabIndex = 7;
            dineInRadioButton.TabStop = true;
            dineInRadioButton.Text = "DineIn";
            dineInRadioButton.UseVisualStyleBackColor = true;
            // 
            // pickUpRadioButton
            // 
            pickUpRadioButton.AutoSize = true;
            pickUpRadioButton.Location = new Point(329, 26);
            pickUpRadioButton.Name = "pickUpRadioButton";
            pickUpRadioButton.Size = new Size(75, 24);
            pickUpRadioButton.TabIndex = 8;
            pickUpRadioButton.TabStop = true;
            pickUpRadioButton.Text = "PickUp";
            pickUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // deliveryRadioButton
            // 
            deliveryRadioButton.AutoSize = true;
            deliveryRadioButton.Location = new Point(630, 26);
            deliveryRadioButton.Name = "deliveryRadioButton";
            deliveryRadioButton.Size = new Size(84, 24);
            deliveryRadioButton.TabIndex = 9;
            deliveryRadioButton.TabStop = true;
            deliveryRadioButton.Text = "Delivery";
            deliveryRadioButton.UseVisualStyleBackColor = true;
            // 
            // infoGroupBox
            // 
            infoGroupBox.Controls.Add(dineInRadioButton);
            infoGroupBox.Controls.Add(pickUpRadioButton);
            infoGroupBox.Controls.Add(deliveryRadioButton);
            infoGroupBox.Location = new Point(12, 12);
            infoGroupBox.Name = "infoGroupBox";
            infoGroupBox.Size = new Size(720, 72);
            infoGroupBox.TabIndex = 11;
            infoGroupBox.TabStop = false;
            // 
            // ordersFlowLayoutPanel
            // 
            ordersFlowLayoutPanel.Location = new Point(12, 109);
            ordersFlowLayoutPanel.Name = "ordersFlowLayoutPanel";
            ordersFlowLayoutPanel.Size = new Size(720, 600);
            ordersFlowLayoutPanel.TabIndex = 12;
            // 
            // ordersButton
            // 
            ordersButton.Location = new Point(894, 124);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(100, 50);
            ordersButton.TabIndex = 13;
            ordersButton.Text = "Orders";
            ordersButton.UseVisualStyleBackColor = true;
            ordersButton.Click += ShowOrdersPanel;
            // 
            // clearCartButton
            // 
            clearCartButton.Location = new Point(787, 68);
            clearCartButton.Name = "clearCartButton";
            clearCartButton.Size = new Size(100, 50);
            clearCartButton.TabIndex = 14;
            clearCartButton.Text = "ClearCart";
            clearCartButton.UseVisualStyleBackColor = true;
            clearCartButton.Click += ClearCart;
            // 
            // formPanel
            // 
            formPanel.Controls.Add(placeOrderButton);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Location = new Point(0, 0);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(1024, 768);
            formPanel.TabIndex = 16;
            // 
            // placeOrderButton
            // 
            placeOrderButton.Location = new Point(891, 180);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Size = new Size(100, 50);
            placeOrderButton.TabIndex = 4;
            placeOrderButton.Text = "Place Order";
            placeOrderButton.UseVisualStyleBackColor = true;
            placeOrderButton.Visible = false;
            placeOrderButton.Click += PlaceOrder;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(clearCartButton);
            Controls.Add(ordersButton);
            Controls.Add(infoGroupBox);
            Controls.Add(homeButton);
            Controls.Add(cartButton);
            Controls.Add(homeFlowLayoutPanel);
            Controls.Add(formPanel);
            Controls.Add(cartFlowLayoutPanel);
            Controls.Add(ordersFlowLayoutPanel);
            Name = "Form1";
            Text = "Form1";
            infoGroupBox.ResumeLayout(false);
            infoGroupBox.PerformLayout();
            formPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel homeFlowLayoutPanel;
        private FlowLayoutPanel cartFlowLayoutPanel;
        private Button cartButton;
        private Button homeButton;
        private RadioButton dineInRadioButton;
        private RadioButton pickUpRadioButton;
        private RadioButton deliveryRadioButton;
        private GroupBox infoGroupBox;
        private FlowLayoutPanel ordersFlowLayoutPanel;
        private Button ordersButton;
        private Button clearCartButton;
        private Panel formPanel;
        private Button placeOrderButton;
    }
}
