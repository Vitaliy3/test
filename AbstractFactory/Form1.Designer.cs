namespace AbstractFactory
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseFactory = new System.Windows.Forms.GroupBox();
            this.CreateChocolate = new System.Windows.Forms.Button();
            this.CreateSweet = new System.Windows.Forms.Button();
            this.CreateKitKat = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ChooseFactory.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseFactory
            // 
            this.ChooseFactory.Controls.Add(this.radioButton2);
            this.ChooseFactory.Controls.Add(this.radioButton1);
            this.ChooseFactory.Location = new System.Drawing.Point(12, 12);
            this.ChooseFactory.Name = "ChooseFactory";
            this.ChooseFactory.Size = new System.Drawing.Size(200, 73);
            this.ChooseFactory.TabIndex = 0;
            this.ChooseFactory.TabStop = false;
            this.ChooseFactory.Text = "Choose Factory";
            // 
            // CreateChocolate
            // 
            this.CreateChocolate.Location = new System.Drawing.Point(15, 100);
            this.CreateChocolate.Name = "CreateChocolate";
            this.CreateChocolate.Size = new System.Drawing.Size(197, 30);
            this.CreateChocolate.TabIndex = 2;
            this.CreateChocolate.Text = "Create Chocolate";
            this.CreateChocolate.UseVisualStyleBackColor = true;
            this.CreateChocolate.Click += new System.EventHandler(this.CreateChocolate_Click);
            // 
            // CreateSweet
            // 
            this.CreateSweet.Location = new System.Drawing.Point(15, 149);
            this.CreateSweet.Name = "CreateSweet";
            this.CreateSweet.Size = new System.Drawing.Size(197, 30);
            this.CreateSweet.TabIndex = 3;
            this.CreateSweet.Text = "Create Sweet";
            this.CreateSweet.UseVisualStyleBackColor = true;
            this.CreateSweet.Click += new System.EventHandler(this.CreateSweet_Click);
            // 
            // CreateKitKat
            // 
            this.CreateKitKat.Location = new System.Drawing.Point(15, 195);
            this.CreateKitKat.Name = "CreateKitKat";
            this.CreateKitKat.Size = new System.Drawing.Size(197, 30);
            this.CreateKitKat.TabIndex = 4;
            this.CreateKitKat.Text = "Create KitKat";
            this.CreateKitKat.UseVisualStyleBackColor = true;
            this.CreateKitKat.Click += new System.EventHandler(this.CreateKitKat_Click);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(15, 241);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(197, 20);
            this.Info.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "FactoryA";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "FactoryB";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 281);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.CreateKitKat);
            this.Controls.Add(this.CreateSweet);
            this.Controls.Add(this.CreateChocolate);
            this.Controls.Add(this.ChooseFactory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ChooseFactory.ResumeLayout(false);
            this.ChooseFactory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ChooseFactory;
        private System.Windows.Forms.Button CreateChocolate;
        private System.Windows.Forms.Button CreateSweet;
        private System.Windows.Forms.Button CreateKitKat;
        private System.Windows.Forms.TextBox Info;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

