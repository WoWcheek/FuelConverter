namespace FuelConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MemuLB = new Label();
            distLB = new Label();
            ordinaryConsumLB = new Label();
            priceLB = new Label();
            distTB = new TextBox();
            ordinaryConsumTB = new TextBox();
            priceTB = new TextBox();
            calculateBtn = new Button();
            fuelLB = new Label();
            fuelCountLB = new Label();
            priceTravelLB = new Label();
            uanLB = new Label();
            dolLB = new Label();
            literLB = new Label();
            uan2LB = new Label();
            dol2LB = new Label();
            kmLb = new Label();
            expensLB = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MemuLB
            // 
            MemuLB.AutoSize = true;
            MemuLB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MemuLB.Location = new Point(42, 39);
            MemuLB.Name = "MemuLB";
            MemuLB.Size = new Size(229, 32);
            MemuLB.TabIndex = 0;
            MemuLB.Text = "Стоимость поездки";
            // 
            // distLB
            // 
            distLB.AutoSize = true;
            distLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            distLB.Location = new Point(42, 95);
            distLB.Name = "distLB";
            distLB.Size = new Size(115, 28);
            distLB.TabIndex = 1;
            distLB.Text = "Расстояние";
            // 
            // ordinaryConsumLB
            // 
            ordinaryConsumLB.AutoSize = true;
            ordinaryConsumLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ordinaryConsumLB.Location = new Point(42, 205);
            ordinaryConsumLB.Name = "ordinaryConsumLB";
            ordinaryConsumLB.Size = new Size(242, 28);
            ordinaryConsumLB.TabIndex = 2;
            ordinaryConsumLB.Text = "Средний расход топлива";
            // 
            // priceLB
            // 
            priceLB.AutoSize = true;
            priceLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLB.Location = new Point(42, 329);
            priceLB.Name = "priceLB";
            priceLB.Size = new Size(183, 28);
            priceLB.TabIndex = 3;
            priceLB.Text = "Стоимость 1 литра";
            // 
            // distTB
            // 
            distTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            distTB.Location = new Point(42, 127);
            distTB.Margin = new Padding(3, 4, 3, 4);
            distTB.Name = "distTB";
            distTB.Size = new Size(242, 39);
            distTB.TabIndex = 4;
            // 
            // ordinaryConsumTB
            // 
            ordinaryConsumTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ordinaryConsumTB.Location = new Point(42, 249);
            ordinaryConsumTB.Margin = new Padding(3, 4, 3, 4);
            ordinaryConsumTB.Name = "ordinaryConsumTB";
            ordinaryConsumTB.Size = new Size(242, 39);
            ordinaryConsumTB.TabIndex = 5;
            // 
            // priceTB
            // 
            priceTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            priceTB.Location = new Point(42, 361);
            priceTB.Margin = new Padding(3, 4, 3, 4);
            priceTB.Name = "priceTB";
            priceTB.Size = new Size(242, 39);
            priceTB.TabIndex = 6;
            // 
            // calculateBtn
            // 
            calculateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            calculateBtn.Location = new Point(42, 432);
            calculateBtn.Margin = new Padding(3, 4, 3, 4);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(114, 67);
            calculateBtn.TabIndex = 7;
            calculateBtn.Text = "Расчитать";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // fuelLB
            // 
            fuelLB.AutoSize = true;
            fuelLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fuelLB.Location = new Point(42, 532);
            fuelLB.Name = "fuelLB";
            fuelLB.Size = new Size(341, 28);
            fuelLB.TabIndex = 8;
            fuelLB.Text = "Необходимое количество топлива: ";
            // 
            // fuelCountLB
            // 
            fuelCountLB.AutoSize = true;
            fuelCountLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fuelCountLB.Location = new Point(377, 532);
            fuelCountLB.Name = "fuelCountLB";
            fuelCountLB.Size = new Size(20, 28);
            fuelCountLB.TabIndex = 9;
            fuelCountLB.Text = "_";
            // 
            // priceTravelLB
            // 
            priceTravelLB.AutoSize = true;
            priceTravelLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceTravelLB.Location = new Point(42, 588);
            priceTravelLB.Name = "priceTravelLB";
            priceTravelLB.Size = new Size(194, 28);
            priceTravelLB.TabIndex = 10;
            priceTravelLB.Text = "Стоимость поездки:";
            // 
            // uanLB
            // 
            uanLB.AutoSize = true;
            uanLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uanLB.Location = new Point(377, 588);
            uanLB.Name = "uanLB";
            uanLB.Size = new Size(20, 28);
            uanLB.TabIndex = 11;
            uanLB.Text = "_";
            // 
            // dolLB
            // 
            dolLB.AutoSize = true;
            dolLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dolLB.Location = new Point(377, 645);
            dolLB.Name = "dolLB";
            dolLB.Size = new Size(20, 28);
            dolLB.TabIndex = 12;
            dolLB.Text = "_";
            // 
            // literLB
            // 
            literLB.AutoSize = true;
            literLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            literLB.Location = new Point(491, 532);
            literLB.Name = "literLB";
            literLB.Size = new Size(27, 28);
            literLB.TabIndex = 13;
            literLB.Text = "л.";
            // 
            // uan2LB
            // 
            uan2LB.AutoSize = true;
            uan2LB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uan2LB.Location = new Point(491, 588);
            uan2LB.Name = "uan2LB";
            uan2LB.Size = new Size(48, 28);
            uan2LB.TabIndex = 14;
            uan2LB.Text = "грн.";
            // 
            // dol2LB
            // 
            dol2LB.AutoSize = true;
            dol2LB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dol2LB.Location = new Point(491, 645);
            dol2LB.Name = "dol2LB";
            dol2LB.Size = new Size(23, 28);
            dol2LB.TabIndex = 15;
            dol2LB.Text = "$";
            // 
            // kmLb
            // 
            kmLb.AutoSize = true;
            kmLb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kmLb.Location = new Point(302, 133);
            kmLb.Name = "kmLb";
            kmLb.Size = new Size(40, 28);
            kmLb.TabIndex = 16;
            kmLb.Text = "км.";
            // 
            // expensLB
            // 
            expensLB.AutoSize = true;
            expensLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            expensLB.Location = new Point(302, 255);
            expensLB.Name = "expensLB";
            expensLB.Size = new Size(107, 28);
            expensLB.TabIndex = 17;
            expensLB.Text = "л / 100 км.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(302, 367);
            label4.Name = "label4";
            label4.Size = new Size(48, 28);
            label4.TabIndex = 18;
            label4.Text = "грн.";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(517, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 685);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(expensLB);
            Controls.Add(kmLb);
            Controls.Add(dol2LB);
            Controls.Add(uan2LB);
            Controls.Add(literLB);
            Controls.Add(dolLB);
            Controls.Add(uanLB);
            Controls.Add(priceTravelLB);
            Controls.Add(fuelCountLB);
            Controls.Add(fuelLB);
            Controls.Add(calculateBtn);
            Controls.Add(priceTB);
            Controls.Add(ordinaryConsumTB);
            Controls.Add(distTB);
            Controls.Add(priceLB);
            Controls.Add(ordinaryConsumLB);
            Controls.Add(distLB);
            Controls.Add(MemuLB);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MemuLB;
        private Label distLB;
        private Label ordinaryConsumLB;
        private Label priceLB;
        private TextBox distTB;
        private TextBox ordinaryConsumTB;
        private TextBox priceTB;
        private Button calculateBtn;
        private Label fuelLB;
        private Label fuelCountLB;
        private Label priceTravelLB;
        private Label uanLB;
        private Label dolLB;
        private Label literLB;
        private Label uan2LB;
        private Label dol2LB;
        private Label kmLb;
        private Label expensLB;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
