namespace Lr2
{
    partial class Form1
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
            this.brand_ = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.MM = new System.Windows.Forms.TextBox();
            this.YYYY = new System.Windows.Forms.TextBox();
            this.Brand = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DD = new System.Windows.Forms.TextBox();
            this.ADD = new System.Windows.Forms.Button();
            this.outDD = new System.Windows.Forms.TextBox();
            this.outYYYY = new System.Windows.Forms.TextBox();
            this.outMM = new System.Windows.Forms.TextBox();
            this.outmodel = new System.Windows.Forms.TextBox();
            this.outbrand = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brand_
            // 
            this.brand_.Location = new System.Drawing.Point(12, 12);
            this.brand_.Name = "brand_";
            this.brand_.Size = new System.Drawing.Size(111, 20);
            this.brand_.TabIndex = 1;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(129, 12);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(111, 20);
            this.model.TabIndex = 2;
            // 
            // MM
            // 
            this.MM.Location = new System.Drawing.Point(280, 12);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(22, 20);
            this.MM.TabIndex = 4;
            // 
            // YYYY
            // 
            this.YYYY.Location = new System.Drawing.Point(302, 12);
            this.YYYY.Name = "YYYY";
            this.YYYY.Size = new System.Drawing.Size(34, 20);
            this.YYYY.TabIndex = 5;
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(47, 35);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(35, 13);
            this.Brand.TabIndex = 6;
            this.Brand.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "DD/MM/YYYY";
            // 
            // DD
            // 
            this.DD.Location = new System.Drawing.Point(258, 12);
            this.DD.Name = "DD";
            this.DD.Size = new System.Drawing.Size(22, 20);
            this.DD.TabIndex = 9;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(361, 12);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(46, 20);
            this.ADD.TabIndex = 10;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // outDD
            // 
            this.outDD.Location = new System.Drawing.Point(258, 51);
            this.outDD.Name = "outDD";
            this.outDD.Size = new System.Drawing.Size(22, 20);
            this.outDD.TabIndex = 18;
            // 
            // outYYYY
            // 
            this.outYYYY.Location = new System.Drawing.Point(302, 51);
            this.outYYYY.Name = "outYYYY";
            this.outYYYY.Size = new System.Drawing.Size(34, 20);
            this.outYYYY.TabIndex = 14;
            // 
            // outMM
            // 
            this.outMM.Location = new System.Drawing.Point(280, 51);
            this.outMM.Name = "outMM";
            this.outMM.Size = new System.Drawing.Size(22, 20);
            this.outMM.TabIndex = 13;
            // 
            // outmodel
            // 
            this.outmodel.Location = new System.Drawing.Point(129, 51);
            this.outmodel.Name = "outmodel";
            this.outmodel.Size = new System.Drawing.Size(111, 20);
            this.outmodel.TabIndex = 12;
            // 
            // outbrand
            // 
            this.outbrand.Location = new System.Drawing.Point(12, 51);
            this.outbrand.Name = "outbrand";
            this.outbrand.Size = new System.Drawing.Size(111, 20);
            this.outbrand.TabIndex = 11;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(129, 77);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(46, 20);
            this.Next.TabIndex = 19;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Prev
            // 
            this.Prev.Location = new System.Drawing.Point(77, 77);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(46, 20);
            this.Prev.TabIndex = 20;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 111);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.outDD);
            this.Controls.Add(this.outYYYY);
            this.Controls.Add(this.outMM);
            this.Controls.Add(this.outmodel);
            this.Controls.Add(this.outbrand);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.DD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.YYYY);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.model);
            this.Controls.Add(this.brand_);
            this.Name = "Form1";
            this.Text = "OrderList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox brand_;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox MM;
        private System.Windows.Forms.TextBox YYYY;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DD;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox outDD;
        private System.Windows.Forms.TextBox outYYYY;
        private System.Windows.Forms.TextBox outMM;
        private System.Windows.Forms.TextBox outmodel;
        private System.Windows.Forms.TextBox outbrand;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Prev;
    }
}

