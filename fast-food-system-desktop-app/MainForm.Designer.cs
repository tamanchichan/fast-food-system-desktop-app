namespace fast_food_system_desktop_app
{
    partial class MainForm
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
            cartProductPlaceholderPanel = new Panel();
            cartProductIncrementOrDecrementLabel = new Label();
            cartProductTotalPricePlaceholder = new Label();
            cartProductQuantityPlaceholder = new Label();
            cartProductPricePlaceholder = new Label();
            cartProductNamePlaceholder = new Label();
            cartProductCodePlaceholder = new Label();
            dataAccessBindingSource = new BindingSource(components);
            addItemToCartTextBox = new TextBox();
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
            addItemToCartPanel = new Panel();
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
            phoneSuggestionsFlowPanel = new FlowLayoutPanel();
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
            cartPanel = new Panel();
            ordersPanel = new Panel();
            orderItemPlaceholderPanel = new Panel();
            orderReadyTimePlaceholder = new Label();
            orderPricePlaceholder = new Label();
            orderQuantityPlaceholder = new Label();
            orderTypePlaceholder = new Label();
            orderNumberPlaceholder = new Label();
            orderDatePlaceholder = new Label();
            clockTimer = new System.Windows.Forms.Timer(components);
            printDialog1 = new PrintDialog();
            cartProductPlaceholderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataAccessBindingSource).BeginInit();
            formPanel.SuspendLayout();
            addItemToCartPanel.SuspendLayout();
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
            cartPanel.SuspendLayout();
            ordersPanel.SuspendLayout();
            orderItemPlaceholderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // homeFlowLayoutPanel
            // 
            homeFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homeFlowLayoutPanel.AutoScroll = true;
            homeFlowLayoutPanel.Font = new Font("Microsoft Sans Serif", 10F);
            homeFlowLayoutPanel.Location = new Point(125, 35);
            homeFlowLayoutPanel.Name = "homeFlowLayoutPanel";
            homeFlowLayoutPanel.Size = new Size(598, 733);
            homeFlowLayoutPanel.TabIndex = 0;
            // 
            // cartProductPlaceholderPanel
            // 
            cartProductPlaceholderPanel.BorderStyle = BorderStyle.FixedSingle;
            cartProductPlaceholderPanel.Controls.Add(cartProductIncrementOrDecrementLabel);
            cartProductPlaceholderPanel.Controls.Add(cartProductTotalPricePlaceholder);
            cartProductPlaceholderPanel.Controls.Add(cartProductQuantityPlaceholder);
            cartProductPlaceholderPanel.Controls.Add(cartProductPricePlaceholder);
            cartProductPlaceholderPanel.Controls.Add(cartProductNamePlaceholder);
            cartProductPlaceholderPanel.Controls.Add(cartProductCodePlaceholder);
            cartProductPlaceholderPanel.Dock = DockStyle.Top;
            cartProductPlaceholderPanel.Location = new Point(0, 0);
            cartProductPlaceholderPanel.Margin = new Padding(0);
            cartProductPlaceholderPanel.Name = "cartProductPlaceholderPanel";
            cartProductPlaceholderPanel.Size = new Size(598, 50);
            cartProductPlaceholderPanel.TabIndex = 0;
            // 
            // cartProductIncrementOrDecrementLabel
            // 
            cartProductIncrementOrDecrementLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cartProductIncrementOrDecrementLabel.BorderStyle = BorderStyle.FixedSingle;
            cartProductIncrementOrDecrementLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            cartProductIncrementOrDecrementLabel.Location = new Point(522, 0);
            cartProductIncrementOrDecrementLabel.Name = "cartProductIncrementOrDecrementLabel";
            cartProductIncrementOrDecrementLabel.Size = new Size(74, 50);
            cartProductIncrementOrDecrementLabel.TabIndex = 5;
            cartProductIncrementOrDecrementLabel.Text = "- / +";
            cartProductIncrementOrDecrementLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cartProductTotalPricePlaceholder
            // 
            cartProductTotalPricePlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cartProductTotalPricePlaceholder.BorderStyle = BorderStyle.FixedSingle;
            cartProductTotalPricePlaceholder.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            cartProductTotalPricePlaceholder.Location = new Point(427, 0);
            cartProductTotalPricePlaceholder.Name = "cartProductTotalPricePlaceholder";
            cartProductTotalPricePlaceholder.RightToLeft = RightToLeft.No;
            cartProductTotalPricePlaceholder.Size = new Size(95, 50);
            cartProductTotalPricePlaceholder.TabIndex = 4;
            cartProductTotalPricePlaceholder.Text = "Total Price";
            cartProductTotalPricePlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cartProductQuantityPlaceholder
            // 
            cartProductQuantityPlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cartProductQuantityPlaceholder.BorderStyle = BorderStyle.FixedSingle;
            cartProductQuantityPlaceholder.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            cartProductQuantityPlaceholder.Location = new Point(327, 0);
            cartProductQuantityPlaceholder.Name = "cartProductQuantityPlaceholder";
            cartProductQuantityPlaceholder.Size = new Size(100, 50);
            cartProductQuantityPlaceholder.TabIndex = 3;
            cartProductQuantityPlaceholder.Text = "Quantity";
            cartProductQuantityPlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cartProductPricePlaceholder
            // 
            cartProductPricePlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cartProductPricePlaceholder.BorderStyle = BorderStyle.FixedSingle;
            cartProductPricePlaceholder.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            cartProductPricePlaceholder.Location = new Point(252, 0);
            cartProductPricePlaceholder.Name = "cartProductPricePlaceholder";
            cartProductPricePlaceholder.Size = new Size(75, 50);
            cartProductPricePlaceholder.TabIndex = 2;
            cartProductPricePlaceholder.Text = "Price";
            cartProductPricePlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cartProductNamePlaceholder
            // 
            cartProductNamePlaceholder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cartProductNamePlaceholder.BorderStyle = BorderStyle.FixedSingle;
            cartProductNamePlaceholder.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            cartProductNamePlaceholder.Location = new Point(75, 0);
            cartProductNamePlaceholder.Name = "cartProductNamePlaceholder";
            cartProductNamePlaceholder.Size = new Size(177, 50);
            cartProductNamePlaceholder.TabIndex = 1;
            cartProductNamePlaceholder.Text = "Product Name";
            cartProductNamePlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cartProductCodePlaceholder
            // 
            cartProductCodePlaceholder.BorderStyle = BorderStyle.FixedSingle;
            cartProductCodePlaceholder.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            cartProductCodePlaceholder.Location = new Point(0, 0);
            cartProductCodePlaceholder.Name = "cartProductCodePlaceholder";
            cartProductCodePlaceholder.Size = new Size(75, 50);
            cartProductCodePlaceholder.TabIndex = 0;
            cartProductCodePlaceholder.Text = "Code";
            cartProductCodePlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addItemToCartTextBox
            // 
            addItemToCartTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addItemToCartTextBox.Location = new Point(6, 3);
            addItemToCartTextBox.Multiline = true;
            addItemToCartTextBox.Name = "addItemToCartTextBox";
            addItemToCartTextBox.Size = new Size(586, 26);
            addItemToCartTextBox.TabIndex = 0;
            addItemToCartTextBox.TextAlign = HorizontalAlignment.Center;
            addItemToCartTextBox.KeyPress += AddItemToCartTextBox_KeyPress;
            // 
            // cartFlowLayoutPanel
            // 
            cartFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartFlowLayoutPanel.AutoScroll = true;
            cartFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            cartFlowLayoutPanel.Font = new Font("Microsoft Sans Serif", 10F);
            cartFlowLayoutPanel.Location = new Point(0, 50);
            cartFlowLayoutPanel.Name = "cartFlowLayoutPanel";
            cartFlowLayoutPanel.Size = new Size(598, 683);
            cartFlowLayoutPanel.TabIndex = 1;
            cartFlowLayoutPanel.WrapContents = false;
            cartFlowLayoutPanel.Resize += CartFlowLayoutPanel_Resize;
            // 
            // cartButton
            // 
            cartButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cartButton.Font = new Font("Microsoft Sans Serif", 10F);
            cartButton.Location = new Point(0, 200);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(123, 100);
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
            homeButton.Size = new Size(123, 100);
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
            deliveryRadioButton.Location = new Point(203, 5);
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
            ordersFlowLayoutPanel.Location = new Point(0, 100);
            ordersFlowLayoutPanel.Name = "ordersFlowLayoutPanel";
            ordersFlowLayoutPanel.Size = new Size(898, 668);
            ordersFlowLayoutPanel.TabIndex = 0;
            // 
            // ordersButton
            // 
            ordersButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ordersButton.Font = new Font("Microsoft Sans Serif", 10F);
            ordersButton.Location = new Point(0, 300);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(123, 100);
            ordersButton.TabIndex = 4;
            ordersButton.Text = "Orders";
            ordersButton.UseVisualStyleBackColor = true;
            ordersButton.Click += ShowOrdersPanel;
            // 
            // clearCartButton
            // 
            clearCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clearCartButton.Font = new Font("Microsoft Sans Serif", 10F);
            clearCartButton.Location = new Point(0, 666);
            clearCartButton.Name = "clearCartButton";
            clearCartButton.Size = new Size(123, 100);
            clearCartButton.TabIndex = 5;
            clearCartButton.Text = "Clear Cart";
            clearCartButton.UseVisualStyleBackColor = true;
            clearCartButton.Click += ClearCart;
            // 
            // formPanel
            // 
            formPanel.Controls.Add(addItemToCartPanel);
            formPanel.Controls.Add(cartDetailsPanel);
            formPanel.Controls.Add(buttonsPanel);
            formPanel.Controls.Add(homeFlowLayoutPanel);
            formPanel.Controls.Add(cartPanel);
            formPanel.Controls.Add(ordersPanel);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Font = new Font("Microsoft Sans Serif", 10F);
            formPanel.Location = new Point(0, 0);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(1024, 768);
            formPanel.TabIndex = 0;
            // 
            // addItemToCartPanel
            // 
            addItemToCartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addItemToCartPanel.Controls.Add(addItemToCartTextBox);
            addItemToCartPanel.Location = new Point(125, 0);
            addItemToCartPanel.Name = "addItemToCartPanel";
            addItemToCartPanel.Size = new Size(598, 35);
            addItemToCartPanel.TabIndex = 0;
            // 
            // cartDetailsPanel
            // 
            cartDetailsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cartDetailsPanel.BorderStyle = BorderStyle.FixedSingle;
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
            clockTimerPanel.Controls.Add(clockTimerLabel);
            clockTimerPanel.Location = new Point(0, 39);
            clockTimerPanel.Name = "clockTimerPanel";
            clockTimerPanel.Size = new Size(298, 76);
            clockTimerPanel.TabIndex = 30;
            // 
            // clockTimerLabel
            // 
            clockTimerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            clockTimerLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clockTimerLabel.Location = new Point(72, 18);
            clockTimerLabel.Name = "clockTimerLabel";
            clockTimerLabel.Size = new Size(160, 42);
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
            observationPlaceholderPanel.Size = new Size(298, 133);
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
            observationTextboxPanel.Size = new Size(290, 100);
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
            observationTextbox.Size = new Size(270, 80);
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
            namePlaceholderPanel.Location = new Point(0, 259);
            namePlaceholderPanel.Name = "namePlaceholderPanel";
            namePlaceholderPanel.Size = new Size(298, 70);
            namePlaceholderPanel.TabIndex = 12;
            // 
            // nameTextboxPanel
            // 
            nameTextboxPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameTextboxPanel.BorderStyle = BorderStyle.FixedSingle;
            nameTextboxPanel.Controls.Add(nameTextbox);
            nameTextboxPanel.Location = new Point(5, 25);
            nameTextboxPanel.Name = "nameTextboxPanel";
            nameTextboxPanel.Size = new Size(288, 40);
            nameTextboxPanel.TabIndex = 20;
            // 
            // nameTextbox
            // 
            nameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameTextbox.BackColor = SystemColors.Control;
            nameTextbox.BorderStyle = BorderStyle.None;
            nameTextbox.Location = new Point(10, 10);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(268, 19);
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
            phoneNumberPlaceholderPanel.Location = new Point(0, 334);
            phoneNumberPlaceholderPanel.Name = "phoneNumberPlaceholderPanel";
            phoneNumberPlaceholderPanel.Size = new Size(298, 70);
            phoneNumberPlaceholderPanel.TabIndex = 14;
            // 
            // phoneNumberTextboxPanel
            // 
            phoneNumberTextboxPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberTextboxPanel.BorderStyle = BorderStyle.FixedSingle;
            phoneNumberTextboxPanel.Controls.Add(phoneNumberTextbox);
            phoneNumberTextboxPanel.Location = new Point(5, 25);
            phoneNumberTextboxPanel.Name = "phoneNumberTextboxPanel";
            phoneNumberTextboxPanel.Size = new Size(288, 40);
            phoneNumberTextboxPanel.TabIndex = 20;
            // 
            // phoneNumberTextbox
            // 
            phoneNumberTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberTextbox.BackColor = SystemColors.Control;
            phoneNumberTextbox.BorderStyle = BorderStyle.None;
            phoneNumberTextbox.Location = new Point(10, 10);
            phoneNumberTextbox.Name = "phoneNumberTextbox";
            phoneNumberTextbox.Size = new Size(268, 19);
            phoneNumberTextbox.TabIndex = 15;
            phoneNumberTextbox.TextChanged += PhoneNumberTextbox_TextChanged;
            phoneNumberTextbox.GotFocus += PhoneNumberTextbox_OnFocus;
            phoneNumberTextbox.KeyPress += PhoneNumberTextbox_KeyPress;
            phoneNumberTextbox.Leave += PhoneNumberTextbox_OnLeave;
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
            addressPlaceholderPanel.Controls.Add(phoneSuggestionsFlowPanel);
            addressPlaceholderPanel.Controls.Add(addressTextboxPanel);
            addressPlaceholderPanel.Controls.Add(addressLabel);
            addressPlaceholderPanel.Font = new Font("Microsoft Sans Serif", 10F);
            addressPlaceholderPanel.Location = new Point(0, 411);
            addressPlaceholderPanel.Name = "addressPlaceholderPanel";
            addressPlaceholderPanel.Size = new Size(298, 70);
            addressPlaceholderPanel.TabIndex = 16;
            // 
            // phoneSuggestionsFlowPanel
            // 
            phoneSuggestionsFlowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phoneSuggestionsFlowPanel.BorderStyle = BorderStyle.FixedSingle;
            phoneSuggestionsFlowPanel.Location = new Point(5, 0);
            phoneSuggestionsFlowPanel.Name = "phoneSuggestionsFlowPanel";
            phoneSuggestionsFlowPanel.Size = new Size(288, 0);
            phoneSuggestionsFlowPanel.TabIndex = 31;
            phoneSuggestionsFlowPanel.Visible = false;
            // 
            // addressTextboxPanel
            // 
            addressTextboxPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addressTextboxPanel.BorderStyle = BorderStyle.FixedSingle;
            addressTextboxPanel.Controls.Add(addressTextbox);
            addressTextboxPanel.Location = new Point(5, 25);
            addressTextboxPanel.Name = "addressTextboxPanel";
            addressTextboxPanel.Size = new Size(288, 40);
            addressTextboxPanel.TabIndex = 20;
            // 
            // addressTextbox
            // 
            addressTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addressTextbox.BackColor = SystemColors.Control;
            addressTextbox.BorderStyle = BorderStyle.None;
            addressTextbox.Location = new Point(10, 10);
            addressTextbox.Name = "addressTextbox";
            addressTextbox.Size = new Size(268, 19);
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
            deliveryFeePlaceholderPanel.Location = new Point(0, 485);
            deliveryFeePlaceholderPanel.Name = "deliveryFeePlaceholderPanel";
            deliveryFeePlaceholderPanel.Size = new Size(298, 60);
            deliveryFeePlaceholderPanel.TabIndex = 18;
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
            deliveryFeeTextbox.TextChanged += DeliveryFeeTextbox_TextChanged;
            deliveryFeeTextbox.GotFocus += DeliveryFeeTextbox_OnFocus;
            deliveryFeeTextbox.KeyPress += DeliveryFeeTextbox_KeyPress;
            deliveryFeeTextbox.Leave += DeliveryFeeTextbox_OnLeave;
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
            totalPricePlaceholderPanel.Location = new Point(0, 656);
            totalPricePlaceholderPanel.Name = "totalPricePlaceholderPanel";
            totalPricePlaceholderPanel.Size = new Size(298, 30);
            totalPricePlaceholderPanel.TabIndex = 23;
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
            totalPriceLabel.Location = new Point(229, 5);
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
            gstPricePlaceholderPanel.Location = new Point(0, 621);
            gstPricePlaceholderPanel.Name = "gstPricePlaceholderPanel";
            gstPricePlaceholderPanel.Size = new Size(298, 30);
            gstPricePlaceholderPanel.TabIndex = 22;
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
            gstPriceLabel.Location = new Point(243, 5);
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
            pstPricePlaceholderPanel.Location = new Point(0, 585);
            pstPricePlaceholderPanel.Name = "pstPricePlaceholderPanel";
            pstPricePlaceholderPanel.Size = new Size(298, 30);
            pstPricePlaceholderPanel.TabIndex = 21;
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
            pstPriceLabel.Location = new Point(244, 5);
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
            subTotalPricePlaceholderPanel.Location = new Point(0, 549);
            subTotalPricePlaceholderPanel.Name = "subTotalPricePlaceholderPanel";
            subTotalPricePlaceholderPanel.Size = new Size(298, 30);
            subTotalPricePlaceholderPanel.TabIndex = 20;
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
            subTotalPriceLabel.Location = new Point(234, 5);
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
            placeOrderButton.Location = new Point(0, 691);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Size = new Size(298, 75);
            placeOrderButton.TabIndex = 24;
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
            radiosPanel.Size = new Size(298, 33);
            radiosPanel.TabIndex = 6;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonsPanel.BorderStyle = BorderStyle.FixedSingle;
            buttonsPanel.Controls.Add(customersButton);
            buttonsPanel.Controls.Add(ordersButton);
            buttonsPanel.Controls.Add(homeButton);
            buttonsPanel.Controls.Add(cartButton);
            buttonsPanel.Controls.Add(clearCartButton);
            buttonsPanel.Font = new Font("Microsoft Sans Serif", 10F);
            buttonsPanel.Location = new Point(0, 0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(125, 768);
            buttonsPanel.TabIndex = 0;
            // 
            // customersButton
            // 
            customersButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customersButton.Font = new Font("Microsoft Sans Serif", 10F);
            customersButton.Location = new Point(0, 100);
            customersButton.Name = "customersButton";
            customersButton.Size = new Size(123, 100);
            customersButton.TabIndex = 2;
            customersButton.Text = "Customers";
            customersButton.UseVisualStyleBackColor = true;
            customersButton.Click += ShowCustomersForm;
            // 
            // cartPanel
            // 
            cartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartPanel.Controls.Add(cartProductPlaceholderPanel);
            cartPanel.Controls.Add(cartFlowLayoutPanel);
            cartPanel.Location = new Point(125, 35);
            cartPanel.Name = "cartPanel";
            cartPanel.Size = new Size(598, 733);
            cartPanel.TabIndex = 0;
            // 
            // ordersPanel
            // 
            ordersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersPanel.Controls.Add(orderItemPlaceholderPanel);
            ordersPanel.Controls.Add(ordersFlowLayoutPanel);
            ordersPanel.Location = new Point(125, 0);
            ordersPanel.Name = "ordersPanel";
            ordersPanel.Size = new Size(898, 768);
            ordersPanel.TabIndex = 0;
            // 
            // orderItemPlaceholderPanel
            // 
            orderItemPlaceholderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            orderItemPlaceholderPanel.BorderStyle = BorderStyle.FixedSingle;
            orderItemPlaceholderPanel.Controls.Add(orderReadyTimePlaceholder);
            orderItemPlaceholderPanel.Controls.Add(orderPricePlaceholder);
            orderItemPlaceholderPanel.Controls.Add(orderQuantityPlaceholder);
            orderItemPlaceholderPanel.Controls.Add(orderTypePlaceholder);
            orderItemPlaceholderPanel.Controls.Add(orderNumberPlaceholder);
            orderItemPlaceholderPanel.Controls.Add(orderDatePlaceholder);
            orderItemPlaceholderPanel.Location = new Point(0, 50);
            orderItemPlaceholderPanel.Name = "orderItemPlaceholderPanel";
            orderItemPlaceholderPanel.Size = new Size(898, 50);
            orderItemPlaceholderPanel.TabIndex = 1;
            // 
            // orderReadyTimePlaceholder
            // 
            orderReadyTimePlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            orderReadyTimePlaceholder.BorderStyle = BorderStyle.FixedSingle;
            orderReadyTimePlaceholder.Location = new Point(651, 0);
            orderReadyTimePlaceholder.Name = "orderReadyTimePlaceholder";
            orderReadyTimePlaceholder.Size = new Size(245, 50);
            orderReadyTimePlaceholder.TabIndex = 5;
            orderReadyTimePlaceholder.Text = "Ready At";
            orderReadyTimePlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderPricePlaceholder
            // 
            orderPricePlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            orderPricePlaceholder.BorderStyle = BorderStyle.FixedSingle;
            orderPricePlaceholder.Location = new Point(549, 0);
            orderPricePlaceholder.Name = "orderPricePlaceholder";
            orderPricePlaceholder.Size = new Size(102, 50);
            orderPricePlaceholder.TabIndex = 4;
            orderPricePlaceholder.Text = "Price";
            orderPricePlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderQuantityPlaceholder
            // 
            orderQuantityPlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            orderQuantityPlaceholder.BorderStyle = BorderStyle.FixedSingle;
            orderQuantityPlaceholder.Location = new Point(469, 0);
            orderQuantityPlaceholder.Name = "orderQuantityPlaceholder";
            orderQuantityPlaceholder.Size = new Size(80, 50);
            orderQuantityPlaceholder.TabIndex = 3;
            orderQuantityPlaceholder.Text = "Quantity";
            orderQuantityPlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderTypePlaceholder
            // 
            orderTypePlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            orderTypePlaceholder.BorderStyle = BorderStyle.FixedSingle;
            orderTypePlaceholder.Location = new Point(344, 0);
            orderTypePlaceholder.Name = "orderTypePlaceholder";
            orderTypePlaceholder.Size = new Size(125, 50);
            orderTypePlaceholder.TabIndex = 2;
            orderTypePlaceholder.Text = "Type";
            orderTypePlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderNumberPlaceholder
            // 
            orderNumberPlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            orderNumberPlaceholder.BorderStyle = BorderStyle.FixedSingle;
            orderNumberPlaceholder.Location = new Point(244, 0);
            orderNumberPlaceholder.Name = "orderNumberPlaceholder";
            orderNumberPlaceholder.Size = new Size(100, 50);
            orderNumberPlaceholder.TabIndex = 1;
            orderNumberPlaceholder.Text = "Number";
            orderNumberPlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderDatePlaceholder
            // 
            orderDatePlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            orderDatePlaceholder.BorderStyle = BorderStyle.FixedSingle;
            orderDatePlaceholder.Location = new Point(0, 0);
            orderDatePlaceholder.Name = "orderDatePlaceholder";
            orderDatePlaceholder.Size = new Size(244, 50);
            orderDatePlaceholder.TabIndex = 0;
            orderDatePlaceholder.Text = "Date";
            orderDatePlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            clockTimer.Interval = 1000;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(formPanel);
            Name = "MainForm";
            Text = "WinForms";
            cartProductPlaceholderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataAccessBindingSource).EndInit();
            formPanel.ResumeLayout(false);
            addItemToCartPanel.ResumeLayout(false);
            addItemToCartPanel.PerformLayout();
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
            cartPanel.ResumeLayout(false);
            ordersPanel.ResumeLayout(false);
            orderItemPlaceholderPanel.ResumeLayout(false);
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
        private FlowLayoutPanel phoneSuggestionsFlowPanel;
        private TextBox addItemToCartTextBox;
        private Panel addItemToCartPanel;
        private BindingSource dataAccessBindingSource;
        private Panel cartProductPlaceholderPanel;
        private Label orderPricePlaceholder;
        private Label cartProductPricePlaceholder;
        private Label cartProductNamePlaceholder;
        private Label cartProductCodePlaceholder;
        private Label cartProductTotalPricePlaceholder;
        private Label cartProductQuantityPlaceholder;
        private Panel cartPanel;
        private PrintDialog printDialog1;
        private Label cartProductIncrementOrDecrementLabel;
        private Panel panel2;
        private Panel ordersPanel;
        private Panel orderPanelForSomething;
        private Panel orderItemPlaceholderPanel;
        private Label orderQuantityPlaceholder;
        private Label orderTypePlaceholder;
        private Label orderNumberPlaceholder;
        private Label orderDatePlaceholder;
        private Label orderReadyTimePlaceholder;
    }
}
