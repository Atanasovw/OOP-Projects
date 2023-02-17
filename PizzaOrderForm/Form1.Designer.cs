namespace PizzaOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboPizzaType = new System.Windows.Forms.ComboBox();
            this.groupSize = new System.Windows.Forms.GroupBox();
            this.radioLarge = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.mayobox = new System.Windows.Forms.CheckBox();
            this.chubricabox = new System.Windows.Forms.CheckBox();
            this.gorchicabox = new System.Windows.Forms.CheckBox();
            this.ketchupbox = new System.Windows.Forms.CheckBox();
            this.groupSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Избери вид пица";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboPizzaType
            // 
            this.comboPizzaType.FormattingEnabled = true;
            this.comboPizzaType.Items.AddRange(new object[] {
            "Маргарита",
            "Калцоне",
            "4 Сирена",
            "Вегетарианска"});
            this.comboPizzaType.Location = new System.Drawing.Point(21, 27);
            this.comboPizzaType.Name = "comboPizzaType";
            this.comboPizzaType.Size = new System.Drawing.Size(184, 23);
            this.comboPizzaType.TabIndex = 1;
            this.comboPizzaType.SelectedIndexChanged += new System.EventHandler(this.comboPizzaType_SelectedIndexChanged);
            // 
            // groupSize
            // 
            this.groupSize.Controls.Add(this.radioLarge);
            this.groupSize.Controls.Add(this.radioMedium);
            this.groupSize.Controls.Add(this.radioSmall);
            this.groupSize.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupSize.Location = new System.Drawing.Point(261, 110);
            this.groupSize.Name = "groupSize";
            this.groupSize.Size = new System.Drawing.Size(140, 102);
            this.groupSize.TabIndex = 0;
            this.groupSize.TabStop = false;
            this.groupSize.Text = "Размер";
            // 
            // radioLarge
            // 
            this.radioLarge.AutoSize = true;
            this.radioLarge.Location = new System.Drawing.Point(6, 72);
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Size = new System.Drawing.Size(75, 21);
            this.radioLarge.TabIndex = 6;
            this.radioLarge.TabStop = true;
            this.radioLarge.Text = "Голяма";
            this.radioLarge.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Location = new System.Drawing.Point(6, 47);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(78, 21);
            this.radioMedium.TabIndex = 5;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Средна";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.Location = new System.Drawing.Point(6, 22);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(68, 21);
            this.radioSmall.TabIndex = 4;
            this.radioSmall.TabStop = true;
            this.radioSmall.Text = "Малка";
            this.radioSmall.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(102, 291);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(220, 34);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Поръчай";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // mayobox
            // 
            this.mayobox.AutoSize = true;
            this.mayobox.Location = new System.Drawing.Point(48, 116);
            this.mayobox.Name = "mayobox";
            this.mayobox.Size = new System.Drawing.Size(81, 19);
            this.mayobox.TabIndex = 4;
            this.mayobox.Text = "Майонеза";
            this.mayobox.UseVisualStyleBackColor = true;
            // 
            // chubricabox
            // 
            this.chubricabox.AutoSize = true;
            this.chubricabox.Location = new System.Drawing.Point(48, 191);
            this.chubricabox.Name = "chubricabox";
            this.chubricabox.Size = new System.Drawing.Size(74, 19);
            this.chubricabox.TabIndex = 5;
            this.chubricabox.Text = "Чубрица";
            this.chubricabox.UseVisualStyleBackColor = true;
            // 
            // gorchicabox
            // 
            this.gorchicabox.AutoSize = true;
            this.gorchicabox.Location = new System.Drawing.Point(48, 166);
            this.gorchicabox.Name = "gorchicabox";
            this.gorchicabox.Size = new System.Drawing.Size(73, 19);
            this.gorchicabox.TabIndex = 6;
            this.gorchicabox.Text = "Горчица";
            this.gorchicabox.UseVisualStyleBackColor = true;
            // 
            // ketchupbox
            // 
            this.ketchupbox.AutoSize = true;
            this.ketchupbox.Location = new System.Drawing.Point(48, 141);
            this.ketchupbox.Name = "ketchupbox";
            this.ketchupbox.Size = new System.Drawing.Size(64, 19);
            this.ketchupbox.TabIndex = 7;
            this.ketchupbox.Text = "Кетчуп";
            this.ketchupbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 386);
            this.Controls.Add(this.ketchupbox);
            this.Controls.Add(this.gorchicabox);
            this.Controls.Add(this.chubricabox);
            this.Controls.Add(this.mayobox);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupSize);
            this.Controls.Add(this.comboPizzaType);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Поръчка на пица";
            this.groupSize.ResumeLayout(false);
            this.groupSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboPizzaType;
        private GroupBox groupSize;
        private RadioButton radioLarge;
        private RadioButton radioMedium;
        private RadioButton radioSmall;
        private Button btnOrder;
        private CheckBox mayobox;
        private CheckBox chubricabox;
        private CheckBox gorchicabox;
        private CheckBox ketchupbox;
    }
}