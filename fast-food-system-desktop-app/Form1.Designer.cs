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
            components = new System.ComponentModel.Container();
            homeFlowLayoutPanel = new FlowLayoutPanel();
            cartFlowLayoutPanel = new FlowLayoutPanel();
            cartButton = new Button();
            homeButton = new Button();
            dineInRadioButton = new RadioButton();
            pickUpRadioButton = new RadioButton();
            deliveryRadioButton = new RadioButton();
            ordersFlowLayoutPanel = new FlowLayoutPanel();
            ordersButton = new Button();
            clearCartButton = new Button();
            formPanel = new Panel();
            cartDetailsPanel = new Panel();
            clockTimerPanel = new Panel();
            clockTimerLabel = new Label();
            observationPlaceholderPanel = new Panel();
            observationTextboxPanel = new Panel();
            observationTextbox = new TextBox();
            observationLabel = new Label();
            namePlaceholderPanel = new Panel();
            nameTextboxPanel = new Panel();
            nameTextbox = new TextBox();
            nameLabel = new Label();
            phoneNumberPlaceholderPanel = new Panel();
            phoneNumberTextboxPanel = new Panel();
            phoneNumberTextbox = new TextBox();
            phoneNumberLabel = new Label();
            addressPlaceholderPanel = new Panel();
            addressTextboxPanel = new Panel();
            addressTextbox = new TextBox();
            addressLabel = new Label();
            deliveryFeePlaceholderPanel = new Panel();
            deliveryFeeTextboxPanel = new Panel();
            deliveryFeeTextbox = new TextBox();
            deliveryFeePlaceholderLabel = new Label();
            totalPricePlaceholderPanel = new Panel();
            totalPricePlaceholderLabel = new Label();
            totalPriceLabel = new Label();
            gstPricePlaceholderPanel = new Panel();
            gstPricePlaceholderLabel = new Label();
            gstPriceLabel = new Label();
            pstPricePlaceholderPanel = new Panel();
            pstPricePlaceholderLabel = new Label();
            pstPriceLabel = new Label();
            subTotalPricePlaceholderPanel = new Panel();
            subTotalPricePlaceholderLabel = new Label();
            subTotalPriceLabel = new Label();
            placeOrderButton = new Button();
            radiosPanel = new Panel();
            buttonsPanel = new Panel();
            customersButton = new Button();
            clockTimer = new System.Windows.Forms.Timer(components);
            formPanel.SuspendLayout();
            cartDetailsPanel.SuspendLayout();
            clockTimerPanel.SuspendLayout();
            observationPlaceholderPanel.SuspendLayout();
            observationTextboxPanel.SuspendLayout();
            namePlaceholderPanel.SuspendLayout();
            nameTextboxPanel.SuspendLayout();
            phoneNumberPlaceholderPanel.SuspendLayout();
            phoneNumberTextboxPanel.SuspendLayout();
            addressPlaceholderPanel.SuspendLayout();
            addressTextboxPanel.SuspendLayout();
            deliveryFeePlaceholderPanel.SuspendLayout();
            deliveryFeeTextboxPanel.SuspendLayout();
            totalPricePlaceholderPanel.SuspendLayout();
            gstPricePlaceholderPanel.SuspendLayout();
            pstPricePlaceholderPanel.SuspendLayout();
            subTotalPricePlaceholderPanel.SuspendLayout();
            radiosPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // homeFlowLayoutPanel
            // 
            homeFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homeFlowLayoutPanel.Font = new Font("Microsoft Sans Serif", 10F);
            homeFlowLayoutPanel.Location = new Point(152, 0);
            homeFlowLayoutPanel.Name = "homeFlowLayoutPanel";
            homeFlowLayoutPanel.Size = new Size(570, 768);
            homeFlowLayoutPanel.TabIndex = 1;
            // 
            // cartFlowLayoutPanel
            // 
            cartFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartFlowLayoutPanel.Font = new Font("Microsoft Sans Serif", 10F);
            cartFlowLayoutPanel.Location = new Point(152, 0);
            cartFlowLayoutPanel.Name = "cartFlowLayoutPanel";
            cartFlowLayoutPanel.Size = new Size(570, 768);
            cartFlowLayoutPanel.TabIndex = 1;
            // 
            // cartButton
            // 
            cartButton.Font = new Font("Microsoft Sans Serif", 10F);
            cartButton.Location = new Point(0, 200);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(150, 100);
            cartButton.TabIndex = 3;
            cartButton.Text = "Cart";
            cartButton.UseVisualStyleBackColor = true;
            cartButton.Click += ShowCartPanel;
            // 
            // homeButton
            // 
            homeButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            homeButton.Font = new Font("Microsoft Sans Serif", 10F);
            homeButton.Location = new Point(0, 0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(150, 100);
            homeButton.TabIndex = 1;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += ShowHomePanel;
            // 
            // dineInRadioButton
            // 
            dineInRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dineInRadioButton.AutoSize = true;
            dineInRadioButton.Font = new Font("Microsoft Sans Serif", 10F);
            dineInRadioButton.Location = new Point(5, 5);
            dineInRadioButton.Name = "dineInRadioButton";
            dineInRadioButton.Size = new Size(84, 24);
            dineInRadioButton.TabIndex = 7;
            dineInRadioButton.TabStop = true;
            dineInRadioButton.Text = "Dine-In";
            dineInRadioButton.UseVisualStyleBackColor = true;
            // 
            // pickUpRadioButton
            // 
            pickUpRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pickUpRadioButton.AutoSize = true;
            pickUpRadioButton.Font = new Font("Microsoft Sans Serif", 10F);
            pickUpRadioButton.Location = new Point(105, 5);
            pickUpRadioButton.Name = "pickUpRadioButton";
            pickUpRadioButton.Size = new Size(89, 24);
            pickUpRadioButton.TabIndex = 8;
            pickUpRadioButton.TabStop = true;
            pickUpRadioButton.Text = "Pick-Up";
            pickUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // deliveryRadioButton
            // 
            deliveryRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deliveryRadioButton.AutoSize = true;
            deliveryRadioButton.Font = new Font("Microsoft Sans Serif", 10F);
            deliveryRadioButton.Location = new Point(204, 5);
            deliveryRadioButton.Name = "deliveryRadioButton";
            deliveryRadioButton.Size = new Size(91, 24);
            deliveryRadioButton.TabIndex = 9;
            deliveryRadioButton.TabStop = true;
            deliveryRadioButton.Text = "Delivery";
            deliveryRadioButton.UseVisualStyleBackColor = true;
            // 
            // ordersFlowLayoutPanel
            // 
            ordersFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersFlowLayoutPanel.Font = new Font("Microsoft Sans Serif", 10F);
            ordersFlowLayoutPanel.Location = new Point(152, 0);
            ordersFlowLayoutPanel.Name = "ordersFlowLayoutPanel";
            ordersFlowLayoutPanel.Size = new Size(872, 765);
            ordersFlowLayoutPanel.TabIndex = 0;
            // 
            // ordersButton
            // 
            ordersButton.Font = new Font("Microsoft Sans Serif", 10F);
            ordersButton.Location = new Point(0, 300);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(150, 100);
            ordersButton.TabIndex = 4;
            ordersButton.Text = "Orders";
            ordersButton.UseVisualStyleBackColor = true;
            ordersButton.Click += ShowOrdersPanel;
            // 
            // clearCartButton
            // 
            clearCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clearCartButton.Font = new Font("Microsoft Sans Serif", 10F);
            clearCartButton.Location = new Point(0, 668);
            clearCartButton.Name = "clearCartButton";
            clearCartButton.Size = new Size(150, 100);
            clearCartButton.TabIndex = 5;
            clearCartButton.Text = "Clear Cart";
            clearCartButton.UseVisualStyleBackColor = true;
            clearCartButton.Click += ClearCart;
            // 
            // formPanel
            // 
            formPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formPanel.Controls.Add(cartDetailsPanel);
            formPanel.Controls.Add(buttonsPanel);
            formPanel.Controls.Add(homeFlowLayoutPanel);
            formPanel.Controls.Add(ordersFlowLayoutPanel);
            formPanel.Controls.Add(cartFlowLayoutPanel);
            formPanel.Font = new Font("Microsoft Sans Serif", 10F);
            formPanel.Location = new Point(0, 0);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(1024, 768);
            formPanel.TabIndex = 0;
            // 
            // cartDetailsPanel
            // 
            cartDetailsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cartDetailsPanel.Controls.Add(clockTimerPanel);
            cartDetailsPanel.Controls.Add(observationPlaceholderPanel);
            cartDetailsPanel.Controls.Add(namePlaceholderPanel);
            cartDetailsPanel.Controls.Add(phoneNumberPlaceholderPanel);
            cartDetailsPanel.Controls.Add(addressPlaceholderPanel);
            cartDetailsPanel.Controls.Add(deliveryFeePlaceholderPanel);
            cartDetailsPanel.Controls.Add(totalPricePlaceholderPanel);
            cartDetailsPanel.Controls.Add(gstPricePlaceholderPanel);
            cartDetailsPanel.Controls.Add(pstPricePlaceholderPanel);
            cartDetailsPanel.Controls.Add(subTotalPricePlaceholderPanel);
            cartDetailsPanel.Controls.Add(placeOrderButton);
            cartDetailsPanel.Controls.Add(radiosPanel);
            cartDetailsPanel.Font = new Font("Microsoft Sans Serif", 10F);
            cartDetailsPanel.Location = new Point(723, 0);
            cartDetailsPanel.Name = "cartDetailsPanel";
            cartDetailsPanel.Size = new Size(300, 768);
            cartDetailsPanel.TabIndex = 2;
            // 
            // clockTimerPanel
            // 
            clockTimerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clockTimerPanel.BorderStyle = BorderStyle.FixedSingle;
            clockTimerPanel.Controls.Add(clockTimerLabel);
            clockTimerPanel.Location = new Point(0, 39);
            clockTimerPanel.Name = "clockTimerPanel";
            clockTimerPanel.Size = new Size(300, 76);
            clockTimerPanel.TabIndex = 30;
            // 
            // clockTimerLabel
            // 
            clockTimerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            clockTimerLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clockTimerLabel.Location = new Point(70, 18);
            clockTimerLabel.Name = "clockTimerLabel";
            clockTimerLabel.Size = new Size(160, 40);
            clockTimerLabel.TabIndex = 0;
            clockTimerLabel.Text = "12:00:00";
            clockTimerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // observationPlaceholderPanel
            // 
            observationPlaceholderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            observationPlaceholderPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            observationPlaceholderPanel.Controls.Add(observationTextboxPanel);
            observationPlaceholderPanel.Controls.Add(observationLabel);
            observationPlaceholderPanel.Location = new Point(0, 121);
            observationPlaceholderPanel.Name = "observationPlaceholderPanel";
            observationPlaceholderPanel.Size = new Size(300, 135);
            observationPlaceholderPanel.TabIndex = 10;
            // 
            // observationTextboxPanel
            // 
            observationTextboxPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            observationTextboxPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            observationTextboxPanel.BorderStyle = BorderStyle.FixedSingle;
            observationTextboxPanel.Controls.Add(observationTextbox);
            observationTextboxPanel.Location = new Point(5, 30);
            observationTextboxPanel.Name = "observationTextboxPanel";
            observationTextboxPanel.Size = new Size(292, 102);
            observationTextboxPanel.TabIndex = 35;
            // 
            // observationTextbox
            // 
            observationTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            observationTextbox.BackColor = SystemColors.Control;
            observationTextbox.BorderStyle = BorderStyle.None;
            observationTextbox.Location = new Point(10, 10);
            observationTextbox.Multiline = true;
            observationTextbox.Name = "observationTextbox";
            observationTextbox.Size = new Size(272, 82);
            observationTextbox.TabIndex = 11;
            // 
            // observationLabel
            // 
            observationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            observationLabel.AutoSize = true;
            observationLabel.Location = new Point(5, 5);
            observationLabel.Name = "observationLabel";
            observationLabel.Size = new Size(125, 20);
            observationLabel.TabIndex = 34;
            observationLabel.Text = "Observation(s):";
            // 
            // namePlaceholderPanel
            // 
            namePlaceholderPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            namePlaceholderPanel.Controls.Add(nameTextboxPanel);
            namePlaceholderPanel.Controls.Add(nameLabel);
            namePlaceholderPanel.Font = new Font("Microsoft Sans Serif", 10F);
            namePlaceholderPanel.Location = new Point(0, 261);
            namePlaceholderPanel.Name = "namePlaceholderPanel";
            namePlaceholderPanel.Size = new Size(300, 70);
            namePlaceholderPanel.TabIndex = 12;
            // 
            // nameTextboxPanel
            // 
            nameTextboxPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameTextboxPanel.BorderStyle = BorderStyle.FixedSingle;
            nameTextboxPanel.Controls.Add(nameTextbox);
            nameTextboxPanel.Location = new Point(5, 25);
            nameTextboxPanel.Name = "nameTextboxPanel";
            nameTextboxPanel.Size = new Size(290, 40);
            nameTextboxPanel.TabIndex = 20;
            // 
            // nameTextbox
            // 
            nameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameTextbox.BackColor = SystemColors.Control;
            nameTextbox.BorderStyle = BorderStyle.None;
            nameTextbox.Location = new Point(10, 10);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(270, 19);
            nameTextbox.TabIndex = 13;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Microsoft Sans Serif", 10F);
            nameLabel.Location = new Point(5, 3);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(58, 20);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Name:";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneNumberPlaceholderPanel
            // 
            phoneNumberPlaceholderPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberPlaceholderPanel.Controls.Add(phoneNumberTextboxPanel);
            phoneNumberPlaceholderPanel.Controls.Add(phoneNumberLabel);
            phoneNumberPlaceholderPanel.Font = new Font("Microsoft Sans Serif", 10F);
            phoneNumberPlaceholderPanel.Location = new Point(0, 336);
            phoneNumberPlaceholderPanel.Name = "phoneNumberPlaceholderPanel";
            phoneNumberPlaceholderPanel.Size = new Size(300, 70);
            phoneNumberPlaceholderPanel.TabIndex = 14;
            // 
            // phoneNumberTextboxPanel
            // 
            phoneNumberTextboxPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberTextboxPanel.BorderStyle = BorderStyle.FixedSingle;
            phoneNumberTextboxPanel.Controls.Add(phoneNumberTextbox);
            phoneNumberTextboxPanel.Location = new Point(5, 25);
            phoneNumberTextboxPanel.Name = "phoneNumberTextboxPanel";
            phoneNumberTextboxPanel.Size = new Size(290, 40);
            phoneNumberTextboxPanel.TabIndex = 20;
            // 
            // phoneNumberTextbox
            // 
            phoneNumberTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberTextbox.BackColor = SystemColors.Control;
            phoneNumberTextbox.BorderStyle = BorderStyle.None;
            phoneNumberTextbox.Location = new Point(10, 10);
            phoneNumberTextbox.Name = "phoneNumberTextbox";
            phoneNumberTextbox.Size = new Size(270, 19);
            phoneNumberTextbox.TabIndex = 15;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Microsoft Sans Serif", 10F);
            phoneNumberLabel.Location = new Point(5, 3);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(125, 20);
            phoneNumberLabel.TabIndex = 18;
            phoneNumberLabel.Text = "Phone Number:";
            phoneNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addressPlaceholderPanel
            // 
            addressPlaceholderPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addressPlaceholderPanel.Controls.Add(addressTextboxPanel);
            addressPlaceholderPanel.Controls.Add(addressLabel);
            addressPlaceholderPanel.Font = new Font("Microsoft Sans Serif", 10F);
            addressPlaceholderPanel.Location = new Point(0, 413);
            addressPlaceholderPanel.Name = "addressPlaceholderPanel";
            addressPlaceholderPanel.Size = new Size(300, 70);
            addressPlaceholderPanel.TabIndex = 16;
            // 
            // addressTextboxPanel
            // 
            addressTextboxPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addressTextboxPanel.BorderStyle = BorderStyle.FixedSingle;
            addressTextboxPanel.Controls.Add(addressTextbox);
            addressTextboxPanel.Location = new Point(5, 25);
            addressTextboxPanel.Name = "addressTextboxPanel";
            addressTextboxPanel.Size = new Size(290, 40);
            addressTextboxPanel.TabIndex = 20;
            // 
            // addressTextbox
            // 
            addressTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addressTextbox.BackColor = SystemColors.Control;
            addressTextbox.BorderStyle = BorderStyle.None;
            addressTextbox.Location = new Point(10, 10);
            addressTextbox.Name = "addressTextbox";
            addressTextbox.Size = new Size(270, 19);
            addressTextbox.TabIndex = 17;
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Microsoft Sans Serif", 10F);
            addressLabel.Location = new Point(5, 3);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(76, 20);
            addressLabel.TabIndex = 18;
            addressLabel.Text = "Address:";
            addressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deliveryFeePlaceholderPanel
            // 
            deliveryFeePlaceholderPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deliveryFeePlaceholderPanel.Controls.Add(deliveryFeeTextboxPanel);
            deliveryFeePlaceholderPanel.Controls.Add(deliveryFeePlaceholderLabel);
            deliveryFeePlaceholderPanel.Font = new Font("Microsoft Sans Serif", 10F);
            deliveryFeePlaceholderPanel.Location = new Point(0, 487);
            deliveryFeePlaceholderPanel.Name = "deliveryFeePlaceholderPanel";
            deliveryFeePlaceholderPanel.Size = new Size(300, 60);
            deliveryFeePlaceholderPanel.TabIndex = 29;
            // 
            // deliveryFeeTextboxPanel
            // 
            deliveryFeeTextboxPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            deliveryFeeTextboxPanel.BorderStyle = BorderStyle.FixedSingle;
            deliveryFeeTextboxPanel.Controls.Add(deliveryFeeTextbox);
            deliveryFeeTextboxPanel.Location = new Point(195, 10);
            deliveryFeeTextboxPanel.Name = "deliveryFeeTextboxPanel";
            deliveryFeeTextboxPanel.Size = new Size(100, 40);
            deliveryFeeTextboxPanel.TabIndex = 20;
            // 
            // deliveryFeeTextbox
            // 
            deliveryFeeTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deliveryFeeTextbox.BackColor = SystemColors.Control;
            deliveryFeeTextbox.BorderStyle = BorderStyle.None;
            deliveryFeeTextbox.Location = new Point(10, 10);
            deliveryFeeTextbox.Name = "deliveryFeeTextbox";
            deliveryFeeTextbox.Size = new Size(80, 19);
            deliveryFeeTextbox.TabIndex = 19;
            deliveryFeeTextbox.TextAlign = HorizontalAlignment.Right;
            deliveryFeeTextbox.TextChanged += DeliveryChargeTextbox_TextChanged;
            deliveryFeeTextbox.KeyPress += DeliveryChargeTextbox_KeyPress;
            // 
            // deliveryFeePlaceholderLabel
            // 
            deliveryFeePlaceholderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deliveryFeePlaceholderLabel.AutoSize = true;
            deliveryFeePlaceholderLabel.Font = new Font("Microsoft Sans Serif", 10F);
            deliveryFeePlaceholderLabel.Location = new Point(5, 20);
            deliveryFeePlaceholderLabel.Name = "deliveryFeePlaceholderLabel";
            deliveryFeePlaceholderLabel.Size = new Size(108, 20);
            deliveryFeePlaceholderLabel.TabIndex = 18;
            deliveryFeePlaceholderLabel.Text = "Delivery Fee:";
            deliveryFeePlaceholderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalPricePlaceholderPanel
            // 
            totalPricePlaceholderPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            totalPricePlaceholderPanel.Controls.Add(totalPricePlaceholderLabel);
            totalPricePlaceholderPanel.Controls.Add(totalPriceLabel);
            totalPricePlaceholderPanel.Font = new Font("Microsoft Sans Serif", 10F);
            totalPricePlaceholderPanel.Location = new Point(0, 658);
            totalPricePlaceholderPanel.Name = "totalPricePlaceholderPanel";
            totalPricePlaceholderPanel.Size = new Size(300, 30);
            totalPricePlaceholderPanel.TabIndex = 28;
            // 
            // totalPricePlaceholderLabel
            // 
            totalPricePlaceholderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            totalPricePlaceholderLabel.AutoSize = true;
            totalPricePlaceholderLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            totalPricePlaceholderLabel.Location = new Point(5, 5);
            totalPricePlaceholderLabel.Name = "totalPricePlaceholderLabel";
            totalPricePlaceholderLabel.Size = new Size(107, 20);
            totalPricePlaceholderLabel.TabIndex = 19;
            totalPricePlaceholderLabel.Text = "Total Price:";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            totalPriceLabel.Location = new Point(231, 5);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(64, 20);
            totalPriceLabel.TabIndex = 25;
            totalPriceLabel.Text = "$16,24";
            totalPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gstPricePlaceholderPanel
            // 
            gstPricePlaceholderPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gstPricePlaceholderPanel.Controls.Add(gstPricePlaceholderLabel);
            gstPricePlaceholderPanel.Controls.Add(gstPriceLabel);
            gstPricePlaceholderPanel.Font = new Font("Microsoft Sans Serif", 10F);
            gstPricePlaceholderPanel.Location = new Point(0, 623);
            gstPricePlaceholderPanel.Name = "gstPricePlaceholderPanel";
            gstPricePlaceholderPanel.Size = new Size(300, 30);
            gstPricePlaceholderPanel.TabIndex = 28;
            // 
            // gstPricePlaceholderLabel
            // 
            gstPricePlaceholderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gstPricePlaceholderLabel.AutoSize = true;
            gstPricePlaceholderLabel.Font = new Font("Microsoft Sans Serif", 10F);
            gstPricePlaceholderLabel.Location = new Point(5, 5);
            gstPricePlaceholderLabel.Name = "gstPricePlaceholderLabel";
            gstPricePlaceholderLabel.Size = new Size(89, 20);
            gstPricePlaceholderLabel.TabIndex = 21;
            gstPricePlaceholderLabel.Text = "GST (5%):";
            // 
            // gstPriceLabel
            // 
            gstPriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gstPriceLabel.AutoSize = true;
            gstPriceLabel.Font = new Font("Microsoft Sans Serif", 10F);
            gstPriceLabel.Location = new Point(245, 5);
            gstPriceLabel.Name = "gstPriceLabel";
            gstPriceLabel.Size = new Size(49, 20);
            gstPriceLabel.TabIndex = 24;
            gstPriceLabel.Text = "$0,73";
            gstPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pstPricePlaceholderPanel
            // 
            pstPricePlaceholderPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pstPricePlaceholderPanel.Controls.Add(pstPricePlaceholderLabel);
            pstPricePlaceholderPanel.Controls.Add(pstPriceLabel);
            pstPricePlaceholderPanel.Font = new Font("Microsoft Sans Serif", 10F);
            pstPricePlaceholderPanel.Location = new Point(0, 587);
            pstPricePlaceholderPanel.Name = "pstPricePlaceholderPanel";
            pstPricePlaceholderPanel.Size = new Size(300, 30);
            pstPricePlaceholderPanel.TabIndex = 27;
            // 
            // pstPricePlaceholderLabel
            // 
            pstPricePlaceholderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pstPricePlaceholderLabel.AutoSize = true;
            pstPricePlaceholderLabel.Font = new Font("Microsoft Sans Serif", 10F);
            pstPricePlaceholderLabel.Location = new Point(5, 5);
            pstPricePlaceholderLabel.Name = "pstPricePlaceholderLabel";
            pstPricePlaceholderLabel.Size = new Size(87, 20);
            pstPricePlaceholderLabel.TabIndex = 20;
            pstPricePlaceholderLabel.Text = "PST (7%):";
            // 
            // pstPriceLabel
            // 
            pstPriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pstPriceLabel.AutoSize = true;
            pstPriceLabel.Font = new Font("Microsoft Sans Serif", 10F);
            pstPriceLabel.Location = new Point(246, 5);
            pstPriceLabel.Name = "pstPriceLabel";
            pstPriceLabel.Size = new Size(49, 20);
            pstPriceLabel.TabIndex = 23;
            pstPriceLabel.Text = "$1,01";
            pstPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subTotalPricePlaceholderPanel
            // 
            subTotalPricePlaceholderPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subTotalPricePlaceholderPanel.Controls.Add(subTotalPricePlaceholderLabel);
            subTotalPricePlaceholderPanel.Controls.Add(subTotalPriceLabel);
            subTotalPricePlaceholderPanel.Font = new Font("Microsoft Sans Serif", 10F);
            subTotalPricePlaceholderPanel.Location = new Point(0, 551);
            subTotalPricePlaceholderPanel.Name = "subTotalPricePlaceholderPanel";
            subTotalPricePlaceholderPanel.Size = new Size(300, 30);
            subTotalPricePlaceholderPanel.TabIndex = 26;
            // 
            // subTotalPricePlaceholderLabel
            // 
            subTotalPricePlaceholderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            subTotalPricePlaceholderLabel.AutoSize = true;
            subTotalPricePlaceholderLabel.Font = new Font("Microsoft Sans Serif", 10F);
            subTotalPricePlaceholderLabel.Location = new Point(5, 5);
            subTotalPricePlaceholderLabel.Name = "subTotalPricePlaceholderLabel";
            subTotalPricePlaceholderLabel.Size = new Size(124, 20);
            subTotalPricePlaceholderLabel.TabIndex = 18;
            subTotalPricePlaceholderLabel.Text = "SubTotal Price:";
            subTotalPricePlaceholderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subTotalPriceLabel
            // 
            subTotalPriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            subTotalPriceLabel.AutoSize = true;
            subTotalPriceLabel.Font = new Font("Microsoft Sans Serif", 10F);
            subTotalPriceLabel.Location = new Point(236, 5);
            subTotalPriceLabel.Name = "subTotalPriceLabel";
            subTotalPriceLabel.Size = new Size(58, 20);
            subTotalPriceLabel.TabIndex = 22;
            subTotalPriceLabel.Text = "$14,50";
            subTotalPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // placeOrderButton
            // 
            placeOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            placeOrderButton.FlatAppearance.BorderSize = 5;
            placeOrderButton.Font = new Font("Microsoft Sans Serif", 10F);
            placeOrderButton.Location = new Point(0, 693);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Size = new Size(300, 75);
            placeOrderButton.TabIndex = 0;
            placeOrderButton.Text = "Place Order";
            placeOrderButton.UseVisualStyleBackColor = true;
            placeOrderButton.Click += PlaceOrder;
            // 
            // radiosPanel
            // 
            radiosPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radiosPanel.Controls.Add(deliveryRadioButton);
            radiosPanel.Controls.Add(pickUpRadioButton);
            radiosPanel.Controls.Add(dineInRadioButton);
            radiosPanel.Font = new Font("Microsoft Sans Serif", 10F);
            radiosPanel.Location = new Point(0, 0);
            radiosPanel.Name = "radiosPanel";
            radiosPanel.Size = new Size(300, 33);
            radiosPanel.TabIndex = 6;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonsPanel.Controls.Add(customersButton);
            buttonsPanel.Controls.Add(ordersButton);
            buttonsPanel.Controls.Add(homeButton);
            buttonsPanel.Controls.Add(cartButton);
            buttonsPanel.Controls.Add(clearCartButton);
            buttonsPanel.Font = new Font("Microsoft Sans Serif", 10F);
            buttonsPanel.Location = new Point(0, 0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(150, 768);
            buttonsPanel.TabIndex = 0;
            // 
            // customersButton
            // 
            customersButton.Font = new Font("Microsoft Sans Serif", 10F);
            customersButton.Location = new Point(0, 100);
            customersButton.Name = "customersButton";
            customersButton.Size = new Size(150, 100);
            customersButton.TabIndex = 2;
            customersButton.Text = "Customers";
            customersButton.UseVisualStyleBackColor = true;
            // 
            // clockTimer
            // 
            clockTimer.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(formPanel);
            Name = "Form1";
            Text = "Form1";
            formPanel.ResumeLayout(false);
            cartDetailsPanel.ResumeLayout(false);
            clockTimerPanel.ResumeLayout(false);
            observationPlaceholderPanel.ResumeLayout(false);
            observationPlaceholderPanel.PerformLayout();
            observationTextboxPanel.ResumeLayout(false);
            observationTextboxPanel.PerformLayout();
            namePlaceholderPanel.ResumeLayout(false);
            namePlaceholderPanel.PerformLayout();
            nameTextboxPanel.ResumeLayout(false);
            nameTextboxPanel.PerformLayout();
            phoneNumberPlaceholderPanel.ResumeLayout(false);
            phoneNumberPlaceholderPanel.PerformLayout();
            phoneNumberTextboxPanel.ResumeLayout(false);
            phoneNumberTextboxPanel.PerformLayout();
            addressPlaceholderPanel.ResumeLayout(false);
            addressPlaceholderPanel.PerformLayout();
            addressTextboxPanel.ResumeLayout(false);
            addressTextboxPanel.PerformLayout();
            deliveryFeePlaceholderPanel.ResumeLayout(false);
            deliveryFeePlaceholderPanel.PerformLayout();
            deliveryFeeTextboxPanel.ResumeLayout(false);
            deliveryFeeTextboxPanel.PerformLayout();
            totalPricePlaceholderPanel.ResumeLayout(false);
            totalPricePlaceholderPanel.PerformLayout();
            gstPricePlaceholderPanel.ResumeLayout(false);
            gstPricePlaceholderPanel.PerformLayout();
            pstPricePlaceholderPanel.ResumeLayout(false);
            pstPricePlaceholderPanel.PerformLayout();
            subTotalPricePlaceholderPanel.ResumeLayout(false);
            subTotalPricePlaceholderPanel.PerformLayout();
            radiosPanel.ResumeLayout(false);
            radiosPanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
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
        private FlowLayoutPanel ordersFlowLayoutPanel;
        private Button ordersButton;
        private Button clearCartButton;
        private Panel formPanel;
        private Panel radiosPanel;
        private Panel buttonsPanel;
        private Panel cartDetailsPanel;
        private Button placeOrderButton;
        private Label gstPricePlaceholderLabel;
        private Label pstPricePlaceholderLabel;
        private Label totalPricePlaceholderLabel;
        private Label subTotalPricePlaceholderLabel;
        private Button customersButton;
        private Label totalPriceLabel;
        private Label gstPriceLabel;
        private Label pstPriceLabel;
        private Label subTotalPriceLabel;
        private Panel totalPricePlaceholderPanel;
        private Panel gstPricePlaceholderPanel;
        private Panel pstPricePlaceholderPanel;
        private Panel subTotalPricePlaceholderPanel;
        private Panel deliveryFeePlaceholderPanel;
        private Label deliveryFeePlaceholderLabel;
        private Panel addressPlaceholderPanel;
        private Label addressLabel;
        private TextBox addressTextbox;
        private Panel namePlaceholderPanel;
        private Panel nameTextboxPanel;
        private TextBox nameTextbox;
        private Label nameLabel;
        private Panel phoneNumberPlaceholderPanel;
        private Panel phoneNumberTextboxPanel;
        private TextBox phoneNumberTextbox;
        private Label phoneNumberLabel;
        private Panel addressTextboxPanel;
        private Panel panel1;
        private Panel deliveryFeeTextboxPanel;
        private TextBox deliveryFeeTextbox;
        private TextBox textBox1;
        private TextBox observationTextbox;
        private Panel observationPlaceholderPanel;
        private Label observationLabel;
        private Panel observationTextboxPanel;
        private Panel clockTimerPanel;
        private Label clockTimerLabel;
        private System.Windows.Forms.Timer clockTimer;
    }
}
