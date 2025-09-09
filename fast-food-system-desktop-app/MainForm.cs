using fast_food_system_desktop_app.Data;
using fast_food_system_desktop_app.Model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace fast_food_system_desktop_app
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DefaultProductsCategories.LinkProductsToCategory(DefaultProducts.appetizerProducts, DefaultCategories.appetizer);
            DefaultProductsCategories.LinkProductsToCategory(DefaultProducts.mixedGreensProducts, DefaultCategories.mixedGreens);

            HomeLoad();
            DisplayCartDetails();

            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();

            this.FormClosing += ClosingHandler;
        }

        private Dictionary<Guid, Label> productQuantityLabels = new Dictionary<Guid, Label>();

        private enum PanelType { Home, Cart, Orders }

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

            else if (currentPanel == PanelType.Orders)
            {
                OrdersLoad();
            }
        }

        protected void HomeLoad()
        {
            homeFlowLayoutPanel.Controls.Clear();

            CreateHomeItems(DataAccess.Products);
        }

        protected void CartLoad()
        {
            cartFlowLayoutPanel.Controls.Clear();

            CreateCartItems(DataAccess.Cart.CartProducts);

            AdjustPlaceholderWidth();
            AdjustCartProductItemWidth();
        }

        protected void OrdersLoad()
        {
            ordersFlowLayoutPanel.Controls.Clear();

            CreateOrderItems(DataAccess.Orders);
        }

        protected void ClosingHandler(object sender, EventArgs e)
        {
            DataAccess.SaveProducts();
            DataAccess.SaveCategories();
            DataAccess.SaveCustomers();
            DataAccess.SaveOrders();
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
                productName.AutoEllipsis = true;
                productName.Text = product.Name;
                productName.Location = new Point(5, 5);
                productName.Width = panel.Width - 10;
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

                Label productQuantity = new Label();
                productQuantity.Tag = product.Id;
                productQuantity.Text = cart.CartProducts.Where(cp => cp.ProductId == product.Id).Sum(cp => cp.Quantity).ToString();
                productQuantity.AutoSize = true;
                productQuantity.BorderStyle = BorderStyle.FixedSingle;
                productQuantity.Location = new Point(
                    panel.Width - productQuantity.PreferredWidth - 10,
                    panel.Height - productQuantity.PreferredHeight - 10
                    );

                productQuantityLabels[product.Id] = productQuantity;

                panel.Controls.Add(productName);
                panel.Controls.Add(productPrice);
                panel.Controls.Add(productCode);
                panel.Controls.Add(productQuantity);

                panel.Click += (sender, e) =>
                {
                    if (product.HasOptions == true)
                    {
                        FlowLayoutPanel flowPanel = new FlowLayoutPanel();
                        formPanel.Controls.Add(flowPanel);

                        flowPanel.BringToFront();
                        flowPanel.Location = new Point(panel.Right, panel.Bottom);
                        flowPanel.AutoSize = false;
                        flowPanel.Width = 150;
                        flowPanel.Height = 0;

                        int panelHeight = 0;

                        foreach (Product.FoodOption foodOption in Enum.GetValues(typeof(Product.FoodOption)))
                        {
                            Label label = new Label();
                            label.AutoSize = false;
                            label.Text = foodOption.ToString();
                            label.Width = flowPanel.Width;
                            label.Height = 30;
                            label.Cursor = Cursors.Hand;

                            label.Click += (s, e) =>
                            {
                                formPanel.Controls.Remove(flowPanel);
                                AddItemToCart(product, foodOption);
                                productQuantity.Text = cart.CartProducts.Where(cp => cp.ProductId == product.Id).Sum(cp => cp.Quantity).ToString();
                                DisplayCartDetails();
                            };

                            flowPanel.Controls.Add(label);

                            panelHeight += label.Height;
                        }

                        flowPanel.Height = panelHeight;

                    }
                    else
                    {
                        AddItemToCart(product);
                        productQuantity.Text = cart.CartProducts.Where(cp => cp.ProductId == product.Id).Sum(cp => cp.Quantity).ToString();
                        DisplayCartDetails();
                    }
                };

                foreach (Control child in panel.Controls)
                {
                    child.Click += (sender, e) =>
                    {
                        if (product.HasOptions == true)
                        {
                            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
                            formPanel.Controls.Add(flowPanel);

                            flowPanel.BringToFront();
                            flowPanel.Location = new Point(panel.Right, panel.Bottom);
                            flowPanel.AutoSize = false;
                            flowPanel.Width = 150;
                            flowPanel.Height = 0;

                            int panelHeight = 0;

                            foreach (Product.FoodOption foodOption in Enum.GetValues(typeof(Product.FoodOption)))
                            {
                                Label label = new Label();
                                label.AutoSize = false;
                                label.Text = foodOption.ToString();
                                label.Width = flowPanel.Width;
                                label.Height = 30;
                                label.Cursor = Cursors.Hand;

                                label.Click += (s, e) =>
                                {
                                    formPanel.Controls.Remove(flowPanel);
                                    AddItemToCart(product, foodOption);
                                    productQuantity.Text = cart.CartProducts.Where(cp => cp.ProductId == product.Id).Sum(cp => cp.Quantity).ToString();
                                    DisplayCartDetails();
                                };

                                flowPanel.Controls.Add(label);

                                panelHeight += label.Height;
                            }

                            flowPanel.Height = panelHeight;
                        }
                        else
                        {
                            AddItemToCart(product);
                            productQuantity.Text = cart.CartProducts.Where(cp => cp.ProductId == product.Id).Sum(cp => cp.Quantity).ToString();

                            DisplayCartDetails();
                        }
                    };
                }

                homeFlowLayoutPanel.Controls.Add(panel);
            }
        }

        private void AddItemToCart(Product product, Product.FoodOption? foodOption = null)
        {
            Cart cart = DataAccess.Cart;

            if (cart == null)
            {
                cart = new Cart();
                DataAccess.Cart = cart;
            }

            cart.CartProducts ??= new HashSet<CartProduct>();
            product.CartProducts ??= new HashSet<CartProduct>();

            CartProduct cartProduct = cart.CartProducts.FirstOrDefault(cp => cp.ProductId == product.Id && cp.SelectedFoodOption == foodOption);

            if (cartProduct == null)
            {
                cartProduct = new CartProduct()
                {
                    CartId = cart.Id,
                    ProductId = product.Id,
                    Code = $"{product.Code}{foodOption?.ToString().Substring(0, 1)}",
                    SelectedFoodOption = foodOption,
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

        // (code * quantity) add item to cart
        private void AddItemToCartTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Product product;
            Product.FoodOption? optionPart = null;
            string input = addItemToCartTextBox.Text.ToString().ToUpper().Trim();
            string inputCode = "";
            string inputQuantity = "";
            string inputDigits = "";
            string inputLetters = "";
            string code = "";

            if (input.Contains("*"))
            {
                string[] parts = input.Split("*");
                inputCode = parts[0].Trim();
                inputQuantity = parts[1].Trim();
            }
            else
            {
                inputCode = input;
                inputQuantity = "1";
            }

            foreach (char c in inputCode)
            {
                if (char.IsDigit(c))
                {
                    inputDigits += c;
                }
                else if (char.IsLetter(c))
                {
                    inputLetters += c;
                }
            }

            #region get food option part
            if (input.Contains("B"))
            {
                optionPart = Product.FoodOption.Beef;
            }
            else if (input.Contains("C"))
            {
                optionPart = Product.FoodOption.Chicken;
            }
            else if (input.Contains("M"))
            {
                optionPart = Product.FoodOption.Mushroom;
            }
            else if (input.Contains("P"))
            {
                optionPart = Product.FoodOption.Pork;
            }
            else if (input.Contains("T"))
            {
                optionPart = Product.FoodOption.Tofu;
            }
            #endregion

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the 'ding' sound

                if (string.IsNullOrEmpty(input))
                {
                    return;
                }
                else
                {
                    // If begins with a letter, code will be "A10"
                    if (char.IsLetter(inputCode[0]))
                    {
                        code = $"{inputLetters}{inputDigits}";
                    }
                    // If begins with a digit, code will be "10A", or just "10" if no letters
                    else
                    {
                        code = inputLetters != string.Empty ? $"{inputDigits}{inputLetters[0]}" : inputDigits;
                    }

                    product = DataAccess.Products.FirstOrDefault(p => p.Code == code);

                    // If a product with code '10A' or 'A10' exists, run this block
                    for (int i = 0; i < int.Parse(inputQuantity); i++)
                    {
                        if (product != null)
                        {
                            if (product.HasOptions == true)
                            {
                                AddItemToCart(product, optionPart);
                            }
                            else
                            {
                                AddItemToCart(product);
                            }
                        }
                        // If a product with code '10B' or 'B10' does not exist, run this block
                        else
                        {
                            if (char.IsLetter(inputCode[0]))
                            {
                                MessageBox.Show($"Product with code '{code}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                addItemToCartTextBox.Text = "";
                                return;
                            }

                            product = DataAccess.Products.FirstOrDefault(p => p.Code == inputDigits);

                            // If a product with code '10' exists, run this block
                            if (product != null)
                            {
                                if (product.HasOptions == true && !string.IsNullOrEmpty(inputLetters))
                                {
                                    AddItemToCart(product, optionPart);
                                }
                                else if (product.HasOptions == false && string.IsNullOrEmpty(inputLetters))
                                {
                                    AddItemToCart(product);
                                }
                                else
                                {
                                    MessageBox.Show($"Product with code '{code}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    addItemToCartTextBox.Text = "";
                                    return;
                                }
                            }
                        }
                    }
                }

                if (productQuantityLabels.ContainsKey(product.Id))
                {
                    productQuantityLabels[product.Id].Text = DataAccess.Cart.CartProducts.Where(cp => cp.ProductId == product.Id).Sum(cp => cp.Quantity).ToString();
                }

                addItemToCartTextBox.Text = "";
                DisplayCartDetails();

                if (currentPanel != PanelType.Home)
                {
                    RefreshCurrentPanel();
                }
            }
        }

        private void CreateCartItemPanel(CartProduct cartProduct)
        {
            Product product = DataAccess.Products.FirstOrDefault(p => p.Id == cartProduct.ProductId);

            Panel panel = new Panel();
            Label code = new Label();
            Label name = new Label();
            Label price = new Label();
            Label quantity = new Label();
            Label totalPrice = new Label();
            Label decrementQuantity = new Label();
            Label incrementQuantity = new Label();
            List<Label> labels = new List<Label>()
            {
                code, name, price, quantity, totalPrice, decrementQuantity, incrementQuantity
            };

            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Height = cartProductPlaceholderPanel.Height;
            panel.Margin = new Padding(0);
            panel.Width = cartProductPlaceholderPanel.Width;


            code.Text = $"{cartProduct.Code}";
            code.Width = cartProductCodePlaceholder.Width;
;
            name.Location = new Point(code.Right, 0);
            name.Text = $"{product.Name} {cartProduct?.SelectedFoodOption}";
            name.Width = cartProductNamePlaceholder.Width;

            price.Location = new Point(name.Right, 0);
            price.Text = cartProduct.Price.ToString("C", new CultureInfo("en-CA"));
            price.Width = cartProductPricePlaceholder.Width;

            quantity.Location = new Point(price.Right, 0);
            quantity.Text = cartProduct.Quantity.ToString();
            quantity.Width = cartProductQuantityPlaceholder.Width;

            totalPrice.Location = new Point(quantity.Right, 0);
            totalPrice.Text = (cartProduct.Quantity * cartProduct.Price).ToString("C", new CultureInfo("en-CA"));
            totalPrice.Width = cartProductTotalPricePlaceholder.Width;

            decrementQuantity.Click += (s, e) =>
            {
               DecrementCartProductQuantity(cartProduct);

                //quantity.Text = cartProduct.Quantity.ToString();
                //totalPrice.Text = (cartProduct.Quantity * cartProduct.Price).ToString("C", new CultureInfo("en-CA"));
                RefreshCurrentPanel();

                DisplayCartDetails();
            };
            decrementQuantity.Location = new Point(totalPrice.Right, 0);
            decrementQuantity.Text = "-";
            decrementQuantity.Width = (cartProductIncrementOrDecrementLabel.Width / 2);

            incrementQuantity.Click += (s, e) =>
            {
                IncrementCartProductQuantity(cartProduct);
                
                //quantity.Text = cartProduct.Quantity.ToString();
                //totalPrice.Text = (cartProduct.Quantity * cartProduct.Price).ToString("C", new CultureInfo("en-CA"));
                RefreshCurrentPanel();

                DisplayCartDetails();
            };
            incrementQuantity.Location = new Point(decrementQuantity.Right, 0);
            incrementQuantity.Text = "+";
            incrementQuantity.Width = (cartProductIncrementOrDecrementLabel.Width / 2);

            foreach (Label label in labels)
            {
                if (label == code)
                {
                    label.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                }
                else if (label == name)
                {
                    label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                }
                else
                {
                    label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                }
                label.AutoSize = false;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Height = cartProductPlaceholderPanel.Height;
                label.TextAlign = ContentAlignment.MiddleCenter;

                panel.Controls.Add(label);
            }

            cartFlowLayoutPanel.Controls.Add(panel);
        }

        private void AdjustPlaceholderWidth()
        {
            int availableWidth = cartProductPlaceholderPanel.Width;

            if (cartFlowLayoutPanel.VerticalScroll.Visible)
                availableWidth -= SystemInformation.VerticalScrollBarWidth;

            cartProductPlaceholderPanel.Width = availableWidth;
        }
        
        private void AdjustCartProductItemWidth()
        {
            int availableWidth = cartProductPlaceholderPanel.Width;

            if (cartFlowLayoutPanel.VerticalScroll.Visible)
                availableWidth -= SystemInformation.VerticalScrollBarWidth;

            foreach (Control ctrl in cartFlowLayoutPanel.Controls)
            {
                ctrl.Width = availableWidth;
            }
        }

        private void CartFlowLayoutPanel_Resize(object sender, EventArgs e)
        {
            AdjustCartProductItemWidth();
            AdjustPlaceholderWidth();
        }

        private void CreateCartItems(HashSet<CartProduct> cartProducts)
        {
            foreach (CartProduct cartProduct in cartProducts)
            {
                CreateCartItemPanel(cartProduct);
            }
        }

        private void IncrementCartProductQuantity(CartProduct cartProduct)
        {
            Product product = DataAccess.Products.FirstOrDefault(p => p.Id == cartProduct.ProductId);

            cartProduct.Quantity++;

            productQuantityLabels[product.Id].Text = cartProduct.Quantity.ToString();
        }

        private void DecrementCartProductQuantity(CartProduct cartProduct)
        {
            Cart cart = DataAccess.Cart;
            Product product = DataAccess.Products.FirstOrDefault(p => p.Id == cartProduct.ProductId);

            if (cartProduct.Quantity == 1)
            {
                cart.CartProducts.Remove(cartProduct);
            }
            else
            {
                cartProduct.Quantity--;
            }

            if (productQuantityLabels.ContainsKey(product.Id))
            {
                productQuantityLabels[product.Id].Text = cartProduct.Quantity.ToString();
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

                    if (productQuantityLabels.ContainsKey(product.Id))
                    {
                        productQuantityLabels[product.Id].Text = cart.CartProducts.Where(cp => cp.ProductId == product.Id).Sum(cp => cp.Quantity).ToString();
                    }
                }
            }

            observationTextbox.Text = "";
            nameTextbox.Text = "";
            phoneNumberTextbox.Text = "";
            addressTextbox.Text = "";
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
            try
            {
                Cart cart = DataAccess.Cart;

                if (cart.CartProducts.Count == 0 || cart.CartProducts == null)
                {
                    throw new ValidationException("Cart is empty. Please add items to the cart before placing an order.");
                }

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

                string phoneNumber = phoneNumberTextbox.Text;

                string digits = new string(phoneNumber.Where(char.IsDigit).ToArray());

                if (!string.IsNullOrEmpty(digits) && digits.Length < 10)
                {
                    throw new ValidationException("Phone Number is invalid. Follow the format: '123-456-7890'");
                }

                Customer customer = DataAccess.Customers.FirstOrDefault(c => c.PhoneNumber == phoneNumber);

                if (customer == null && phoneNumber != "")
                {
                    customer = new Customer()
                    {
                        //    Id = Guid.NewGuid();
                        //    Name = name;
                        //    PhoneNumber = phoneNumber;
                        //    Address = address;
                        //    Observations = observations;
                        //    Orders = orders;

                        Id = Guid.NewGuid(),
                        Name = nameTextbox.Text,
                        PhoneNumber = phoneNumberTextbox.Text,
                        Address = addressTextbox.Text
                    };

                    DataAccess.Customers.Add(customer);
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
                    PhoneNumber = phoneNumberTextbox.Text,
                    Type = selectedOrderType,
                    Observation = observationTextbox.Text,
                    DeliveryFee = deliveryFee,
                    SubTotal = subTotal,
                    Pst = pst,
                    Gst = gst,
                    Total = total
                };

                if (customer != null)
                {
                    order.CustomerId = customer.Id;
                }

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
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateOrderItem(Order order)
        {
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
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

            ordersPanel.SendToBack();

            homeFlowLayoutPanel.SendToBack();

            cartPanel.BringToFront();

            cartDetailsPanel.BringToFront();

            CartLoad();
        }

        private void ShowHomePanel(object sender, EventArgs e)
        {
            currentPanel = PanelType.Home;

            cartPanel.SendToBack();

            ordersPanel.SendToBack();

            homeFlowLayoutPanel.BringToFront();

            cartDetailsPanel.BringToFront();
        }

        private void ShowOrdersPanel(object sender, EventArgs e)
        {
            currentPanel = PanelType.Orders;

            cartPanel.SendToBack();

            cartDetailsPanel.SendToBack();

            homeFlowLayoutPanel.SendToBack();

            ordersPanel.BringToFront();

            OrdersLoad();
        }

        private void ShowCustomersForm(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            customersForm.ShowDialog();
        }

        private void DeliveryFeeTextbox_TextChanged(object sender, EventArgs e)
        {
            DisplayCartDetails();
        }

        // convert from "$0.00" to "0.00"
        private void DeliveryFeeTextbox_OnFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (decimal.TryParse(textBox.Text, NumberStyles.Currency, new CultureInfo("en-CA"), out decimal value))
            {
                textBox.Text = value.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                textBox.Text = "0.00"; // default if parsing fails
            }

            textBox.SelectionStart = textBox.Text.Length; // place cursor at the end
        }

        // convert from "0.00" to "$0.00"
        private void DeliveryFeeTextbox_OnLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (decimal.TryParse(textBox.Text, NumberStyles.Currency, new CultureInfo("en-CA"), out decimal value))
            {
                textBox.Text = value.ToString("C", new CultureInfo("en-CA"));
            }
        }

        private void DeliveryFeeTextbox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PhoneNumberTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '+' && textBox.SelectionStart == 0 && !(textBox.Text.Contains("+")))
            {
                return;
            }

            if (e.KeyChar == '-' && (textBox.Text.Count(c => c == '-') < 2))
            {
                return;
            }

            e.Handled = true;
        }

        private void PhoneNumberTextbox_TextChanged(object sender, EventArgs e)
        {
            #region format phoneNumber textbox (xxx-xxx-xxxx)
            TextBox textBox = (TextBox)sender;

            string digits = new string(textBox.Text.Where(char.IsDigit).ToArray());

            if (digits.Length > 0)
            {
                if (digits.Length <= 3)
                {
                    textBox.Text = digits;
                }
                else if (digits.Length <= 6)
                {
                    textBox.Text = $"{digits.Substring(0, 3)}-{digits.Substring(3)}";
                }
                else if (digits.Length <= 10)
                {
                    textBox.Text = $"{digits.Substring(0, 3)}-{digits.Substring(3, 3)}-{digits.Substring(6)}";
                }
                else
                {
                    textBox.Text = $"{digits.Substring(0, 3)}-{digits.Substring(3, 3)}-{digits.Substring(6, 4)}";
                }

                textBox.SelectionStart = textBox.Text.Length;
            }
            #endregion

            phoneSuggestionsFlowPanel.Controls.Clear();
            phoneSuggestionsFlowPanel.BringToFront();

            string input = phoneNumberTextbox.Text.Trim();

            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                phoneSuggestionsFlowPanel.Visible = false;
                return;
            }

            int panelHeight = 0;

            foreach (Customer customer in DataAccess.Customers)
            {
                if (customer.PhoneNumber.Contains(input))
                {
                    Label phoneSuggestionLabel = new Label();
                    phoneSuggestionLabel.Text = customer.PhoneNumber;
                    phoneSuggestionLabel.AutoSize = false;
                    phoneSuggestionLabel.Width = phoneSuggestionsFlowPanel.Width;
                    phoneSuggestionLabel.Height = 30;
                    phoneSuggestionLabel.TextAlign = ContentAlignment.MiddleLeft;
                    phoneSuggestionLabel.BackColor = Color.White;
                    phoneSuggestionLabel.Cursor = Cursors.Hand;
                    phoneSuggestionLabel.Margin = new Padding(0);

                    phoneSuggestionLabel.MouseHover += (s, e) =>
                    {
                        phoneSuggestionLabel.BackColor = Color.Silver;
                    };

                    phoneSuggestionLabel.MouseLeave += (s, e) =>
                    {
                        phoneSuggestionLabel.BackColor = Color.White;
                    };

                    // Click event to fill textbox
                    phoneSuggestionLabel.Click += (s, e) =>
                    {
                        nameTextbox.Text = customer.Name;
                        phoneNumberTextbox.Text = customer.PhoneNumber;
                        addressTextbox.Text = customer.Address;
                        phoneSuggestionsFlowPanel.Visible = false;
                    };

                    phoneSuggestionsFlowPanel.Controls.Add(phoneSuggestionLabel);
                    panelHeight += phoneSuggestionLabel.Height;
                }
            }

            phoneSuggestionsFlowPanel.Height = panelHeight;
            phoneSuggestionsFlowPanel.Visible = panelHeight > 0;
        }

        private void PhoneNumberTextbox_OnLeave(object sender, EventArgs e)
        {
            phoneSuggestionsFlowPanel.Visible = false;
        }

        private void PhoneNumberTextbox_OnFocus(object sender, EventArgs e)
        {
            if (phoneNumberTextbox.Text.Length >= 2)

                phoneSuggestionsFlowPanel.Visible = true;
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            clockTimerLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
            clockTimerLabel.Location = new Point((clockTimerPanel.Width - clockTimerLabel.Width) / 2, (clockTimerPanel.Height - clockTimerLabel.Height) / 2);
        }
    }
}
