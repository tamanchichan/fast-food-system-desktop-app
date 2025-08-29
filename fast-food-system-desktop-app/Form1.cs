using fast_food_system_desktop_app.Data;
using fast_food_system_desktop_app.Model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Globalization;

namespace fast_food_system_desktop_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            HomeLoad();
            DisplayCartDetails();

            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();

            this.FormClosing += ClosingHandler;
        }

        private enum PanelType { Home, Cart } // Add Order later

        private PanelType currentPanel = PanelType.Home;

        private void RefreshCurrentPanel()
        {
            if (currentPanel == PanelType.Home)
            {
                HomeLoad();
            }
            else if (currentPanel == PanelType.Cart)
            {
                CartLoad();
            }

            // Uncomment this when OrdersLoad is implemented
            // else if (currentPanel == PanelType.Orders)
            //{
            //    OrdersLoad();
            //}
        }

        protected void HomeLoad()
        {
            homeFlowLayoutPanel.Controls.Clear();

            DefaultProductsCategories.LinkProductsToCategory(DefaultProducts.appetizerProducts, DefaultCategories.appetizer);

            CreateHomeItems(DataAccess.Products);

            homeFlowLayoutPanel.BringToFront();
            cartDetailsPanel.BringToFront();
        }

        protected void CartLoad()
        {
            cartFlowLayoutPanel.Controls.Clear();

            CreateCartItems(DataAccess.Cart.CartProducts);

            cartFlowLayoutPanel.BringToFront();
            cartDetailsPanel.BringToFront();
        }

        protected void OrdersLoad()
        {
            ordersFlowLayoutPanel.Controls.Clear();

            CreateOrderItems(DataAccess.Orders);

            ordersFlowLayoutPanel.BringToFront();
        }

        protected void ClosingHandler(object sender, EventArgs e)
        {
            DataAccess.SaveProducts();
            DataAccess.SaveCategories();
            DataAccess.SaveCarts();
        }

        private void CreateHomeItems(HashSet<Product> products)
        {
            Cart cart = DataAccess.Cart;

            foreach (Product product in products)
            {
                product.CartProducts ??= new HashSet<CartProduct>();
                product.ProductCategories ??= new HashSet<ProductCategory>();

                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.Size = new Size(200, 100);
                panel.Cursor = Cursors.Hand;

                Label productName = new Label();
                productName.Text = product.Name;
                productName.Location = new Point(5, 5);
                productName.AutoSize = true;
                productName.Cursor = Cursors.Hand;

                Label productPrice = new Label();
                productPrice.Text = product.Price.ToString("C", new CultureInfo("en-CA"));
                productPrice.Location = new Point(
                    (panel.Width - productPrice.PreferredWidth) / 2,
                    (panel.Height - productPrice.PreferredHeight) / 2
                    );
                productPrice.Cursor = Cursors.Hand;

                Label productCode = new Label();
                productCode.AutoSize = true;
                productCode.BorderStyle = BorderStyle.FixedSingle;
                productCode.Text = product.Code;
                productCode.Location = new Point(
                    5,
                    panel.Height - productCode.PreferredHeight - 10
                    );

                CartProduct cartProduct = cart.CartProducts.FirstOrDefault(cp => cp.ProductId == product.Id);

                Label productQuantity = new Label();
                productQuantity.Text = (cartProduct?.Quantity ?? 0).ToString();
                productQuantity.AutoSize = true;
                productQuantity.BorderStyle = BorderStyle.FixedSingle;
                productQuantity.Location = new Point(
                    panel.Width - productQuantity.PreferredWidth - 10,
                    panel.Height - productQuantity.PreferredHeight - 10
                    );

                panel.Controls.Add(productName);
                panel.Controls.Add(productPrice);
                panel.Controls.Add(productCode);
                panel.Controls.Add(productQuantity);

                panel.Click += (sender, e) =>
                {
                    AddItemToCart(product);

                    CartProduct cartProduct = cart.CartProducts.FirstOrDefault(cp => cp.ProductId == product.Id);

                    productQuantity.Text = (cartProduct?.Quantity ?? 0).ToString();

                    DisplayCartDetails();
                };

                foreach (Control child in panel.Controls)
                {
                    child.Click += (sender, e) =>
                    {
                        AddItemToCart(product);

                        CartProduct cartProduct = cart.CartProducts.FirstOrDefault(cp => cp.ProductId == product.Id);

                        productQuantity.Text = (cartProduct?.Quantity ?? 0).ToString();

                        DisplayCartDetails();
                    };
                }

                homeFlowLayoutPanel.Controls.Add(panel);
            }
        }

        private void AddItemToCart(Product product)
        {
            Cart cart = DataAccess.Cart;

            // If cart is null, create a new one
            if (cart == null)
            {
                cart = new Cart();
                DataAccess.Cart = cart;
            }

            cart.CartProducts ??= new HashSet<CartProduct>();
            product.CartProducts ??= new HashSet<CartProduct>();

            CartProduct cartProduct = cart.CartProducts.FirstOrDefault(cp => cp.ProductId == product.Id);

            if (cartProduct == null)
            {
                //cartProduct = new CartProduct(cart.Id, cart, product.Id, product, product.Price, 1, null);

                cartProduct = new CartProduct()
                {
                    CartId = cart.Id,
                    //Cart = cart,
                    ProductId = product.Id,
                    //Product = product,
                    Price = product.Price,
                    Quantity = 1,
                    Observation = null,
                };

                cart.CartProducts.Add(cartProduct);
                product.CartProducts.Add(cartProduct);
            }
            else
            {
                cartProduct.Quantity++;
            }
        }

        private void CreateCartItems(HashSet<CartProduct> cartProducts)
        {
            Panel placeholderPanel = new Panel();
            placeholderPanel.BorderStyle = BorderStyle.Fixed3D;
            placeholderPanel.Size = new Size(cartFlowLayoutPanel.Width, 50);

            Label placeholderCode = new Label();
            placeholderCode.BorderStyle = BorderStyle.FixedSingle;
            //placeholderCode.Size = new Size(100, placeholderPanel.Height);
            placeholderCode.Size = new Size((int)(cartFlowLayoutPanel.Width * 0.10), placeholderPanel.Height);
            placeholderCode.Text = "Code";
            placeholderCode.TextAlign = ContentAlignment.MiddleCenter;

            Label placeholderName = new Label();
            placeholderName.BorderStyle = BorderStyle.FixedSingle;
            //placeholderName.Size = new Size(300, placeholderPanel.Height);
            placeholderName.Size = new Size((int)(cartFlowLayoutPanel.Width * 0.50), placeholderPanel.Height);
            placeholderName.Text = "Name";
            placeholderName.TextAlign = ContentAlignment.MiddleCenter;
            //placeholderName.Location = new Point(100, 0);
            placeholderName.Location = new Point(placeholderCode.Width, 0);

            Label placeholderPrice = new Label();
            placeholderPrice.BorderStyle = BorderStyle.FixedSingle;
            placeholderPrice.Size = new Size((int)(cartFlowLayoutPanel.Width * 0.10), placeholderPanel.Height);
            placeholderPrice.Text = "Price";
            placeholderPrice.TextAlign = ContentAlignment.MiddleCenter;
            placeholderPrice.Location = new Point(placeholderCode.Width + placeholderName.Width, 0);

            Label placeholderQuantity = new Label();
            placeholderQuantity.BorderStyle = BorderStyle.FixedSingle;
            placeholderQuantity.Size = new Size((int)(cartFlowLayoutPanel.Width * 0.15), placeholderPanel.Height);
            placeholderQuantity.Text = "Quantity";
            placeholderQuantity.TextAlign = ContentAlignment.MiddleCenter;
            placeholderQuantity.Location = new Point(placeholderCode.Width + placeholderName.Width + placeholderPrice.Width, 0);

            Label placeholderTotalPrice = new Label();
            placeholderTotalPrice.BorderStyle = BorderStyle.FixedSingle;
            placeholderTotalPrice.Size = new Size((int)(cartFlowLayoutPanel.Width * 0.15), placeholderPanel.Height);
            placeholderTotalPrice.Text = "Total Price";
            placeholderTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            placeholderTotalPrice.Location = new Point(placeholderCode.Width + placeholderName.Width + placeholderPrice.Width + placeholderQuantity.Width, 0);

            placeholderPanel.Controls.Add(placeholderCode);
            placeholderPanel.Controls.Add(placeholderName);
            placeholderPanel.Controls.Add(placeholderPrice);
            placeholderPanel.Controls.Add(placeholderQuantity);
            placeholderPanel.Controls.Add(placeholderTotalPrice);

            cartFlowLayoutPanel.Controls.Add(placeholderPanel);

            foreach (CartProduct cartProduct in cartProducts)
            {
                Product product = DataAccess.Products.FirstOrDefault(p => p.Id == cartProduct.ProductId);

                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.Fixed3D;
                panel.Cursor = Cursors.Hand;
                panel.Margin = new Padding(panel.Margin.Left, 0, panel.Margin.Right, 0);
                panel.Size = new Size(cartFlowLayoutPanel.Width, 50);

                Label cpCode = new Label();
                //cpCode.AutoSize = true;
                cpCode.Size = new Size(placeholderCode.Width, panel.Height);
                //cpCode.Text = cartProduct.Product.Code;
                cpCode.Text = product.Code;
                cpCode.TextAlign = ContentAlignment.MiddleCenter;
                //cpCode.Location = new Point(5, (panel.Height - cpCode.PreferredHeight) / 2);

                Label cpName = new Label();
                //cpName.AutoSize = true;
                cpName.Size = new Size(placeholderName.Width, panel.Height);
                //cpName.Text = cartProduct.Product.Name;
                cpName.Text = product.Name;
                cpName.TextAlign = ContentAlignment.MiddleCenter;
                //cpName.Location = new Point((cpCode.PreferredWidth + 10), (panel.Height - cpName.PreferredHeight) / 2);
                cpName.Location = new Point(cpCode.Width, 0);


                Label cpPrice = new Label();
                //cpPrice.AutoSize = true;
                cpPrice.Size = new Size(placeholderPrice.Width, panel.Height);
                cpPrice.Text = cartProduct.Price.ToString("C", new CultureInfo("en-CA"));
                cpPrice.TextAlign = ContentAlignment.MiddleCenter;
                //cpPrice.Location = new Point((cpCode.PreferredWidth + cpName.PreferredWidth + 10), (panel.Height - cpPrice.PreferredHeight) / 2);
                cpPrice.Location = new Point(cpCode.Width + cpName.Width, 0);

                Label cpQuantity = new Label();
                //cpQuantity.AutoSize = true;
                cpQuantity.Size = new Size(placeholderQuantity.Width, panel.Height);
                cpQuantity.Text = cartProduct.Quantity.ToString();
                cpQuantity.TextAlign = ContentAlignment.MiddleCenter;
                //cpQuantity.Location = new Point((cpCode.PreferredWidth + cpName.PreferredWidth + cpPrice.PreferredWidth + 10), (panel.Height - cpQuantity.PreferredHeight) / 2);
                cpQuantity.Location = new Point(cpCode.Width + cpName.Width + cpPrice.Width, 0);

                Label cpTotalPrice = new Label();
                //cpTotalPrice.AutoSize = true;
                cpTotalPrice.Size = new Size (placeholderTotalPrice.Width, panel.Height);
                cpTotalPrice.Text = (cartProduct.Quantity * cartProduct.Price).ToString("C", new CultureInfo("en-CA"));
                cpTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
                //cpTotalPrice.Location = new Point((cpCode.PreferredWidth + cpName.PreferredWidth + cpPrice.PreferredWidth + cpQuantity.PreferredWidth + 10), (panel.Height - cpTotalPrice.PreferredHeight) / 2);
                cpTotalPrice.Location = new Point(cpCode.Width + cpName.Width + cpPrice.Width + cpQuantity.Width, 0);

                panel.Controls.Add(cpCode);
                panel.Controls.Add(cpName);
                panel.Controls.Add(cpPrice);
                panel.Controls.Add(cpQuantity);
                panel.Controls.Add(cpTotalPrice);

                cartFlowLayoutPanel.Controls.Add(panel);
            }
        }

        private void ClearCart(object sender, EventArgs e)
        {
            Cart cart = DataAccess.Cart;
            HashSet<Product> products = DataAccess.Products;

            foreach (CartProduct cartProduct in cart.CartProducts)
            {
                cart.CartProducts.Remove(cartProduct);

                Product product = products.FirstOrDefault(p => p.Id == cartProduct.ProductId);

                if (product != null)
                {
                    product.CartProducts.Remove(cartProduct);
                }
            }

            deliveryFeeTextbox.Text = 0m.ToString("C", new CultureInfo("en-CA"));

            DisplayCartDetails();

            RefreshCurrentPanel();
        }

        private void DisplayCartDetails()
        {
            Cart cart = DataAccess.Cart;
            decimal deliveryCharge = deliveryFeeTextbox.Text == "" ? 0m : decimal.Parse(deliveryFeeTextbox.Text, NumberStyles.Currency, new CultureInfo("en-CA"));
            decimal subTotal = deliveryCharge + (cart.CartProducts.Sum(cp => cp.Quantity * cp.Price));
            decimal pst = subTotal * 0.07m;
            decimal gst = subTotal * 0.05m;
            decimal total = subTotal + pst + gst;

            subTotalPriceLabel.Text = subTotal.ToString("C", new CultureInfo("en-CA"));
            subTotalPriceLabel.Location = new Point(subTotalPricePlaceholderPanel.Width - subTotalPriceLabel.PreferredWidth, 5);

            pstPriceLabel.Text = pst.ToString("C", new CultureInfo("en-CA"));
            pstPriceLabel.Location = new Point(pstPricePlaceholderPanel.Width - pstPriceLabel.PreferredWidth, 5);

            gstPriceLabel.Text = gst.ToString("C", new CultureInfo("en-CA"));
            gstPriceLabel.Location = new Point(gstPricePlaceholderPanel.Width - gstPriceLabel.PreferredWidth, 5);

            totalPriceLabel.Text = total.ToString("C", new CultureInfo("en-CA"));
            totalPriceLabel.Location = new Point(totalPricePlaceholderPanel.Width - totalPriceLabel.PreferredWidth, 5);
        }

        private void PlaceOrder(object sender, EventArgs e)
        {
            Cart cart = DataAccess.Cart;
            decimal deliveryFee = deliveryFeeTextbox.Text == "" ? 0m : decimal.Parse(deliveryFeeTextbox.Text, NumberStyles.Currency, new CultureInfo("en-CA"));
            decimal subTotal = deliveryFee + (cart.CartProducts.Sum(cp => cp.Price * cp.Quantity));
            decimal pst = subTotal * 0.07m;
            decimal gst = subTotal * 0.05m;
            decimal total = subTotal + pst + gst;

            Order.OrderType selectedOrderType = Order.OrderType.PickUp;

            foreach (RadioButton radioButton in radiosPanel.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    if (radioButton.Text == "Dine-In")
                    {
                        selectedOrderType = Order.OrderType.DineIn;
                    }
                    else if (radioButton.Text == "Pick-Up")
                    {
                        selectedOrderType = Order.OrderType.PickUp;
                    }
                    else if (radioButton.Text == "Delivery")
                    {
                        selectedOrderType = Order.OrderType.Delivery;
                    }
                }

                radioButton.Checked = false;
            }

            Order order = new Order()
            {
                //Id = Guid.NewGuid();
                //Number = _lastOrderNumber++;
                //DateOfCreation = DateTime.Now;
                //CartId = cartId;
                //CustomerId = customerId;
                //PhoneNumber = phoneNumber;
                //Type = orderType;
                //Observation = observation;
                //DeliveryFee = deliveryFee,
                //SubTotal = subTotal;
                //Pst = pst;
                //Gst = gst;
                //Total = total;

                CartId = cart.Id,
                // CustomerId = 
                PhoneNumber = phoneNumberTextbox.Text,
                Type = selectedOrderType,
                // Observation =
                DeliveryFee = deliveryFee,
                SubTotal = subTotal,
                Pst = pst,
                Gst = gst,
                Total = total
            };

            DataAccess.Carts.Add(cart); // Save the current cart
            DataAccess.Cart = new Cart(); // Create a new cart for the next order
            DataAccess.Carts.Add(DataAccess.Cart); // Add the new cart to the list
            DataAccess.SaveCarts(); // Save the carts to the file

            DataAccess.Orders.Add(order); // Add the order to the list
            DataAccess.SaveOrders(); // Save the orders to the file

            cart = DataAccess.Cart; // Get the new cart

            ClearCart(sender, e);

            ShowHomePanel(sender, e);
        }

        private void CreateOrderItems(HashSet<Order> orders)
        {
            int leftPadding = 10;

            ordersFlowLayoutPanel.AutoScroll = true;
            ordersFlowLayoutPanel.VerticalScroll.Visible = true;

            foreach (Order order in orders.OrderByDescending(o => o.Number))
            {
                Cart cart = DataAccess.Carts.FirstOrDefault(c => c.Id == order.CartId);

                Panel orderPanel = new Panel();
                orderPanel.BorderStyle = BorderStyle.FixedSingle;
                orderPanel.Height = 50;
                orderPanel.Width = (ordersFlowLayoutPanel.Width - leftPadding - SystemInformation.VerticalScrollBarWidth);

                Label orderDateOfCreationLabel = new Label();
                orderDateOfCreationLabel.Size = new Size((int)(orderPanel.Width * 0.30), orderPanel.Height);
                orderDateOfCreationLabel.Text = order.DateOfCreation.ToLocalTime().ToString();
                orderDateOfCreationLabel.TextAlign = ContentAlignment.MiddleCenter;

                Label orderNumberLabel = new Label();
                orderNumberLabel.Location = new Point(orderDateOfCreationLabel.Right, 0);
                orderNumberLabel.Size = new Size((int)(orderPanel.Width * 0.20), orderPanel.Height);
                orderNumberLabel.Text = order.Number.ToString();
                orderNumberLabel.TextAlign = ContentAlignment.MiddleCenter;

                Label orderTypeLabel = new Label();
                orderTypeLabel.Location = new Point(orderNumberLabel.Right, 0);
                orderTypeLabel.Size = new Size((int)(orderPanel.Width * 0.20), orderPanel.Height);
                orderTypeLabel.Text = order.Type.ToString();
                orderTypeLabel.TextAlign = ContentAlignment.MiddleCenter;

                Label orderQuantityLabel = new Label();
                orderQuantityLabel.Location = new Point(orderTypeLabel.Right, 0);
                orderQuantityLabel.Size = new Size((int)(orderPanel.Width * 0.15), orderPanel.Height);
                orderQuantityLabel.Text = cart.CartProducts.Sum(cp => cp.Quantity).ToString();
                orderQuantityLabel.TextAlign = ContentAlignment.MiddleCenter;

                Label orderTotalPriceLabel = new Label();
                orderTotalPriceLabel.Location = new Point(orderQuantityLabel.Right, 0);
                orderTotalPriceLabel.Size = new Size((int)(orderPanel.Width * 0.15), orderPanel.Height);
                orderTotalPriceLabel.Text = order.Total.ToString("C", new CultureInfo("en-CA"));
                orderTotalPriceLabel.TextAlign = ContentAlignment.MiddleCenter;

                orderPanel.Controls.Add(orderDateOfCreationLabel);
                orderPanel.Controls.Add(orderNumberLabel);
                orderPanel.Controls.Add(orderTypeLabel);
                orderPanel.Controls.Add(orderQuantityLabel);
                orderPanel.Controls.Add(orderTotalPriceLabel);

                ordersFlowLayoutPanel.Controls.Add(orderPanel);
            }
        }

        private void ShowCartPanel(object sender, EventArgs e)
        {
            currentPanel = PanelType.Cart;
            CartLoad();
        }

        private void ShowHomePanel(object sender, EventArgs e)
        {
            currentPanel = PanelType.Home;
            HomeLoad();
        }

        private void ShowOrdersPanel(object sender, EventArgs e)
        {
            OrdersLoad();
        }

        private void DeliveryChargeTextbox_TextChanged(object sender, EventArgs e)
        {
            DisplayCartDetails();
        }

        private void DeliveryChargeTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
            {
                return;
            }

            e.Handled = true;
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            clockTimerLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
            clockTimerLabel.Location = new Point((clockTimerPanel.Width - clockTimerLabel.Width) / 2, (clockTimerPanel.Height - clockTimerLabel.Height) / 2);
        }
    }
}
