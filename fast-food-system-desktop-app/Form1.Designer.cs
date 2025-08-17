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
            homePanel = new FlowLayoutPanel();
            cartPanel = new FlowLayoutPanel();
            cartButton = new Button();
            homeButton = new Button();
            placeOrderButton = new Button();
            phoneNumberLabel = new Label();
            dineInRadioButton = new RadioButton();
            pickUpRadioButton = new RadioButton();
            deliveryRadioButton = new RadioButton();
            phoneNumberText = new TextBox();
            infoGroupBox = new GroupBox();
            ordersPanel = new FlowLayoutPanel();
            ordersButton = new Button();
            clearCartButton = new Button();
            infoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Location = new Point(12, 109);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(720, 600);
            homePanel.TabIndex = 0;
            // 
            // cartPanel
            // 
            cartPanel.Location = new Point(12, 109);
            cartPanel.Name = "cartPanel";
            cartPanel.Size = new Size(720, 600);
            cartPanel.TabIndex = 1;
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
            // placeOrderButton
            // 
            placeOrderButton.Location = new Point(894, 659);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Size = new Size(100, 50);
            placeOrderButton.TabIndex = 4;
            placeOrderButton.Text = "Place Order";
            placeOrderButton.UseVisualStyleBackColor = true;
            placeOrderButton.Visible = false;
            placeOrderButton.Click += PlaceOrder;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(6, 113);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(108, 20);
            phoneNumberLabel.TabIndex = 5;
            phoneNumberLabel.Text = "Phone Number";
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
            pickUpRadioButton.Location = new Point(6, 56);
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
            deliveryRadioButton.Location = new Point(6, 86);
            deliveryRadioButton.Name = "deliveryRadioButton";
            deliveryRadioButton.Size = new Size(84, 24);
            deliveryRadioButton.TabIndex = 9;
            deliveryRadioButton.TabStop = true;
            deliveryRadioButton.Text = "Delivery";
            deliveryRadioButton.UseVisualStyleBackColor = true;
            // 
            // phoneNumberText
            // 
            phoneNumberText.Location = new Point(6, 136);
            phoneNumberText.Name = "phoneNumberText";
            phoneNumberText.Size = new Size(108, 27);
            phoneNumberText.TabIndex = 10;
            // 
            // infoGroupBox
            // 
            infoGroupBox.Controls.Add(dineInRadioButton);
            infoGroupBox.Controls.Add(phoneNumberText);
            infoGroupBox.Controls.Add(pickUpRadioButton);
            infoGroupBox.Controls.Add(deliveryRadioButton);
            infoGroupBox.Controls.Add(phoneNumberLabel);
            infoGroupBox.Location = new Point(781, 428);
            infoGroupBox.Name = "infoGroupBox";
            infoGroupBox.Size = new Size(213, 183);
            infoGroupBox.TabIndex = 11;
            infoGroupBox.TabStop = false;
            // 
            // ordersPanel
            // 
            ordersPanel.Location = new Point(12, 109);
            ordersPanel.Name = "ordersPanel";
            ordersPanel.Size = new Size(720, 600);
            ordersPanel.TabIndex = 12;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(clearCartButton);
            Controls.Add(ordersButton);
            Controls.Add(infoGroupBox);
            Controls.Add(homePanel);
            Controls.Add(cartPanel);
            Controls.Add(placeOrderButton);
            Controls.Add(homeButton);
            Controls.Add(cartButton);
            Controls.Add(ordersPanel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            infoGroupBox.ResumeLayout(false);
            infoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel homePanel;
        private FlowLayoutPanel cartPanel;
        private Button cartButton;
        private Button homeButton;
        private Button placeOrderButton;
        private Label phoneNumberLabel;
        private RadioButton dineInRadioButton;
        private RadioButton pickUpRadioButton;
        private RadioButton deliveryRadioButton;
        private TextBox phoneNumberText;
        private GroupBox infoGroupBox;
        private FlowLayoutPanel ordersPanel;
        private Button ordersButton;
        private Button clearCartButton;
    }
}
