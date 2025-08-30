namespace fast_food_system_desktop_app
{
    partial class CustomersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customersPanel = new Panel();
            SuspendLayout();
            // 
            // customersPanel
            // 
            customersPanel.Dock = DockStyle.Fill;
            customersPanel.Location = new Point(0, 0);
            customersPanel.Name = "customersPanel";
            customersPanel.Size = new Size(800, 450);
            customersPanel.TabIndex = 0;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customersPanel);
            Name = "CustomersForm";
            Text = "CustomersForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel customersPanel;
    }
}