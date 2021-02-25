using System.Drawing;
using System.Windows.Forms;

namespace Best_Oli
{
    partial class Best_Oli
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
            panel_gass = new  Panel();
            gass_panel_rezult = new  Panel();
            gass_panel_rezult_txt = new  Label();
            gass_lable_grn3 = new  Label();
            gass_panel_rezult_mony = new  Label();
            gass_lable_l = new  Label();
            gass_lable_grn2 = new  Label();
            price = new  Label();
            cout_mony = new  TextBox();
            cout_litrs = new  TextBox();
            gass_lable_grn = new  Label();
            gass_panel_radio = new  Panel();
            rb_sum = new  RadioButton();
            rb_count = new  RadioButton();
            gass_panel_price = new  Label();
            gass_panel_name_box = new  Label();
            gass_panel_box = new  ComboBox();
            gass_panel_name = new  Label();
            panel_cafe = new  Panel();
            numeric_G = new  NumericUpDown();
            numeric_potato = new  NumericUpDown();
            numeric_cola = new  NumericUpDown();
            numeric_hot = new  NumericUpDown();
            price_G = new  Label();
            price_potato = new  Label();
            price_cola = new  Label();
            price_hot = new  Label();
            cafe_panel_count = new  Label();
            cafe_panel_price = new  Label();
            kola = new  CheckBox();
            potato = new  CheckBox();
            gamburger = new  CheckBox();
            hot_dog = new  CheckBox();
            panel2 = new  Panel();
            cafe_panel_rezult_txt = new  Label();
            label2 = new  Label();
            cafe_panel_rezult_mony = new  Label();
            cafe_panel_name = new  Label();
            rezult_panel = new  Panel();
            label3 = new  Label();
            rezult_price = new  Label();
            label1 = new  Label();
            butt_rezult = new  Button();
            panel_gass.SuspendLayout();
            gass_panel_rezult.SuspendLayout();
            gass_panel_radio.SuspendLayout();
            panel_cafe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_potato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_hot)).BeginInit();
            panel2.SuspendLayout();
            rezult_panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel_gass
            // 
            panel_gass.BorderStyle =  BorderStyle.Fixed3D;
            panel_gass.Controls.Add(this.gass_panel_rezult);
            panel_gass.Controls.Add(this.gass_lable_l);
            panel_gass.Controls.Add(this.gass_lable_grn2);
            panel_gass.Controls.Add(this.price);
            panel_gass.Controls.Add(this.cout_mony);
            panel_gass.Controls.Add(this.cout_litrs);
            panel_gass.Controls.Add(this.gass_lable_grn);
            panel_gass.Controls.Add(this.gass_panel_radio);
            panel_gass.Controls.Add(this.gass_panel_price);
            panel_gass.Controls.Add(this.gass_panel_name_box);
            panel_gass.Controls.Add(this.gass_panel_box);
            panel_gass.Controls.Add(this.gass_panel_name);
            panel_gass.Location = new  Point(12, 19);
            panel_gass.Name = "panel_gass";
            panel_gass.Size = new  Size(272, 369);
            panel_gass.TabIndex = 0;
            // 
            // gass_panel_rezult
            // 
            gass_panel_rezult.BorderStyle =  BorderStyle.Fixed3D;
            gass_panel_rezult.Controls.Add(this.gass_panel_rezult_txt);
            gass_panel_rezult.Controls.Add(this.gass_lable_grn3);
            gass_panel_rezult.Controls.Add(this.gass_panel_rezult_mony);
            gass_panel_rezult.Location = new  Point(10, 255);
            gass_panel_rezult.Name = "gass_panel_rezult";
            gass_panel_rezult.Size = new  Size(242, 100);
            gass_panel_rezult.TabIndex = 12;
            // 
            // gass_panel_rezult_txt
            // 
            gass_panel_rezult_txt.AutoSize = true;
            gass_panel_rezult_txt.Font = new  Font("Microsoft Sans Serif", 8F,  FontStyle.Regular,  GraphicsUnit.Point, ((byte)(204)));
            gass_panel_rezult_txt.ForeColor =  SystemColors.Highlight;
            gass_panel_rezult_txt.Location = new  Point(3, 0);
            gass_panel_rezult_txt.Name = "gass_panel_rezult_txt";
            gass_panel_rezult_txt.Size = new  Size(52, 13);
            gass_panel_rezult_txt.TabIndex = 14;
            gass_panel_rezult_txt.Text = "К оплате";
            gass_panel_rezult_txt.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // gass_lable_grn3
            // 
            gass_lable_grn3.AutoSize = true;
            gass_lable_grn3.ForeColor =  SystemColors.Desktop;
            gass_lable_grn3.Location = new  Point(215, 70);
            gass_lable_grn3.Name = "gass_lable_grn3";
            gass_lable_grn3.Size = new  Size(24, 13);
            gass_lable_grn3.TabIndex = 13;
            gass_lable_grn3.Text = "грн";
            gass_lable_grn3.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // gass_panel_rezult_mony
            // 
            gass_panel_rezult_mony.Font = new  Font("Microsoft Sans Serif", 25F,  FontStyle.Regular,  GraphicsUnit.Point, ((byte)(204)));
            gass_panel_rezult_mony.ForeColor =  SystemColors.ControlText;
            gass_panel_rezult_mony.Location = new  Point(85, 23);
            gass_panel_rezult_mony.Name = "gass_panel_rezult_mony";
            gass_panel_rezult_mony.Size = new  Size(124, 60);
            gass_panel_rezult_mony.TabIndex = 13;
            gass_panel_rezult_mony.Text = "0";
            gass_panel_rezult_mony.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // gass_lable_l
            // 
            gass_lable_l.AutoSize = true;
            gass_lable_l.ForeColor =  SystemColors.Highlight;
            gass_lable_l.Location = new  Point(236, 166);
            gass_lable_l.Name = "gass_lable_l";
            gass_lable_l.Size = new  Size(16, 13);
            gass_lable_l.TabIndex = 11;
            gass_lable_l.Text = "л.";
            // 
            // gass_lable_grn2
            // 
            gass_lable_grn2.AutoSize = true;
            gass_lable_grn2.ForeColor =  SystemColors.Highlight;
            gass_lable_grn2.Location = new  Point(236, 202);
            gass_lable_grn2.Name = "gass_lable_grn2";
            gass_lable_grn2.Size = new  Size(24, 13);
            gass_lable_grn2.TabIndex = 10;
            gass_lable_grn2.Text = "грн";
            // 
            // price
            // 
            price.BackColor =  SystemColors.ButtonHighlight;
            price.Font = new  Font("Microsoft Sans Serif", 10F,  FontStyle.Regular,  GraphicsUnit.Point, ((byte)(204)));
            price.ForeColor =  SystemColors.Desktop;
            price.Location = new  Point(124, 103);
            price.Name = "price";
            price.Size = new  Size(106, 20);
            price.TabIndex = 9;
            price.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // cout_mony
            // 
            cout_mony.Enabled = false;
            cout_mony.Location = new  Point(124, 198);
            cout_mony.Name = "cout_mony";
            cout_mony.Size = new  Size(106, 20);
            cout_mony.TabIndex = 8;
            // 
            // cout_litrs
            // 
            cout_litrs.Location = new  Point(124, 159);
            cout_litrs.Name = "cout_litrs";
            cout_litrs.Size = new  Size(106, 20);
            cout_litrs.TabIndex = 7;
            cout_litrs.Text = "0";
            // 
            // gass_lable_grn
            // 
            gass_lable_grn.AutoSize = true;
            gass_lable_grn.ForeColor =  SystemColors.Highlight;
            gass_lable_grn.Location = new  Point(236, 110);
            gass_lable_grn.Name = "gass_lable_grn";
            gass_lable_grn.Size = new  Size(24, 13);
            gass_lable_grn.TabIndex = 6;
            gass_lable_grn.Text = "грн";
            // 
            // gass_panel_radio
            // 
            gass_panel_radio.BorderStyle =  BorderStyle.Fixed3D;
            gass_panel_radio.Controls.Add(this.rb_sum);
            gass_panel_radio.Controls.Add(this.rb_count);
            gass_panel_radio.Location = new  Point(6, 147);
            gass_panel_radio.Name = "gass_panel_radio";
            gass_panel_radio.Size = new  Size(107, 82);
            gass_panel_radio.TabIndex = 5;
            // 
            // rb_sum
            // 
            rb_sum.AutoSize = true;
            rb_sum.Location = new  Point(4, 51);
            rb_sum.Name = "rb_sum";
            rb_sum.Size = new  Size(59, 17);
            rb_sum.TabIndex = 1;
            rb_sum.TabStop = true;
            rb_sum.Text = "Сумма";
            rb_sum.UseVisualStyleBackColor = true;
            // 
            // rb_count
            // 
            rb_count.AutoSize = true;
            rb_count.Checked = true;
            rb_count.Location = new  Point(4, 15);
            rb_count.Name = "rb_count";
            rb_count.Size = new  Size(84, 17);
            rb_count.TabIndex = 0;
            rb_count.TabStop = true;
            rb_count.Text = "Количество";
            rb_count.UseVisualStyleBackColor = true;
            // 
            // gass_panel_price
            // 
            gass_panel_price.AutoSize = true;
            gass_panel_price.ForeColor =  SystemColors.Highlight;
            gass_panel_price.Location = new  Point(21, 103);
            gass_panel_price.Name = "gass_panel_price";
            gass_panel_price.Size = new  Size(33, 13);
            gass_panel_price.TabIndex = 3;
            gass_panel_price.Text = "Цена";
            // 
            // gass_panel_name_box
            // 
            gass_panel_name_box.AutoSize = true;
            gass_panel_name_box.ForeColor =  SystemColors.Highlight;
            gass_panel_name_box.Location = new  Point(21, 48);
            gass_panel_name_box.Name = "gass_panel_name_box";
            gass_panel_name_box.Size = new  Size(44, 13);
            gass_panel_name_box.TabIndex = 2;
            gass_panel_name_box.Text = "Бензин";
            // 
            // gass_panel_box
            // 
            gass_panel_box.FormattingEnabled = true;
            gass_panel_box.Location = new  Point(124, 45);
            gass_panel_box.Name = "gass_panel_box";
            gass_panel_box.Size = new  Size(106, 21);
            gass_panel_box.TabIndex = 1;
            // 
            // gass_panel_name
            // 
            gass_panel_name.AutoSize = true;
            gass_panel_name.ForeColor =  SystemColors.Highlight;
            gass_panel_name.Location = new  Point(3, -1);
            gass_panel_name.Name = "gass_panel_name";
            gass_panel_name.Size = new  Size(79, 13);
            gass_panel_name.TabIndex = 0;
            gass_panel_name.Text = "Автозаправка";
            // 
            // panel_cafe
            // 
            panel_cafe.BorderStyle =  BorderStyle.Fixed3D;
            panel_cafe.Controls.Add(this.numeric_G);
            panel_cafe.Controls.Add(this.numeric_potato);
            panel_cafe.Controls.Add(this.numeric_cola);
            panel_cafe.Controls.Add(this.numeric_hot);
            panel_cafe.Controls.Add(this.price_G);
            panel_cafe.Controls.Add(this.price_potato);
            panel_cafe.Controls.Add(this.price_cola);
            panel_cafe.Controls.Add(this.price_hot);
            panel_cafe.Controls.Add(this.cafe_panel_count);
            panel_cafe.Controls.Add(this.cafe_panel_price);
            panel_cafe.Controls.Add(this.kola);
            panel_cafe.Controls.Add(this.potato);
            panel_cafe.Controls.Add(this.gamburger);
            panel_cafe.Controls.Add(this.hot_dog);
            panel_cafe.Controls.Add(this.panel2);
            panel_cafe.Controls.Add(this.cafe_panel_name);
            panel_cafe.Location = new  Point(339, 19);
            panel_cafe.Name = "panel_cafe";
            panel_cafe.Size = new  Size(296, 369);
            panel_cafe.TabIndex = 1;
            // 
            // numeric_G
            // 
            numeric_G.Location = new  Point(230, 96);
            numeric_G.Name = "numeric_G";
            numeric_G.Size = new  Size(59, 20);
            numeric_G.TabIndex = 25;
            // 
            // numeric_potato
            // 
            numeric_potato.Location = new  Point(230, 146);
            numeric_potato.Name = "numeric_potato";
            numeric_potato.Size = new  Size(59, 20);
            numeric_potato.TabIndex = 24;
            // 
            // numeric_cola
            // 
            numeric_cola.Location = new  Point(230, 195);
            numeric_cola.Name = "numeric_cola";
            numeric_cola.Size = new  Size(59, 20);
            numeric_cola.TabIndex = 23;
            // 
            // numeric_hot
            // 
            numeric_hot.Location = new  Point(230, 45);
            numeric_hot.Name = "numeric_hot";
            numeric_hot.Size = new  Size(59, 20);
            numeric_hot.TabIndex = 22;
            // 
            // price_G
            // 
            price_G.BackColor =  SystemColors.ButtonHighlight;
            price_G.Font = new  Font("Microsoft Sans Serif", 10F,  FontStyle.Regular,  GraphicsUnit.Point, ((byte)(204)));
            price_G.ForeColor =  SystemColors.Desktop;
            price_G.Location = new  Point(142, 96);
            price_G.Name = "price_G";
            price_G.Size = new  Size(57, 20);
            price_G.TabIndex = 21;
            price_G.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // price_potato
            // 
            price_potato.BackColor =  SystemColors.ButtonHighlight;
            price_potato.Font = new  Font("Microsoft Sans Serif", 10F,  FontStyle.Regular,  GraphicsUnit.Point, ((byte)(204)));
            price_potato.ForeColor =  SystemColors.Desktop;
            price_potato.Location = new  Point(143, 144);
            price_potato.Name = "price_potato";
            price_potato.Size = new  Size(55, 20);
            price_potato.TabIndex = 20;
            price_potato.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // price_cola
            // 
            price_cola.BackColor =  SystemColors.ButtonHighlight;
            price_cola.Font = new  Font("Microsoft Sans Serif", 10F,  FontStyle.Regular,  GraphicsUnit.Point, ((byte)(204)));
            price_cola.ForeColor =  SystemColors.Desktop;
            price_cola.Location = new  Point(140, 195);
            price_cola.Name = "price_cola";
            price_cola.Size = new  Size(58, 20);
            price_cola.TabIndex = 19;
            price_cola.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // price_hot
            // 
            price_hot.BackColor =  SystemColors.ButtonHighlight;
            price_hot.Font = new  Font("Microsoft Sans Serif", 10F,  FontStyle.Regular,  GraphicsUnit.Point, ((byte)(204)));
            price_hot.ForeColor =  SystemColors.Desktop;
            price_hot.Location = new  Point(143, 48);
            price_hot.Name = "price_hot";
            price_hot.Size = new  Size(55, 20);
            price_hot.TabIndex = 18;
            price_hot.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // cafe_panel_count
            // 
            cafe_panel_count.AutoSize = true;
            cafe_panel_count.ForeColor =  SystemColors.Highlight;
            cafe_panel_count.Location = new  Point(223, 20);
            cafe_panel_count.Name = "cafe_panel_count";
            cafe_panel_count.Size = new  Size(66, 13);
            cafe_panel_count.TabIndex = 17;
            cafe_panel_count.Text = "Количество";
            // 
            // cafe_panel_price
            // 
            cafe_panel_price.AutoSize = true;
            cafe_panel_price.ForeColor =  SystemColors.Highlight;
            cafe_panel_price.Location = new  Point(165, 20);
            cafe_panel_price.Name = "cafe_panel_price";
            cafe_panel_price.Size = new  Size(33, 13);
            cafe_panel_price.TabIndex = 13;
            cafe_panel_price.Text = "Цена";
            // 
            // kola
            // 
            kola.AutoSize = true;
            kola.Location = new  Point(28, 198);
            kola.Name = "kola";
            kola.Size = new  Size(51, 17);
            kola.TabIndex = 16;
            kola.Text = "Кола";
            // 
            // potato
            // 
            potato.AutoSize = true;
            potato.Location = new  Point(28, 147);
            potato.Name = "potato";
            potato.Size = new  Size(99, 17);
            potato.TabIndex = 15;
            potato.Text = "Картошка фри";
            potato.UseVisualStyleBackColor = true;
            // 
            // gamburger
            // 
            gamburger.AutoSize = true;
            gamburger.Location = new  Point(28, 102);
            gamburger.Name = "gamburger";
            gamburger.Size = new  Size(80, 17);
            gamburger.TabIndex = 14;
            gamburger.Text = "Гамбургер";
            gamburger.UseVisualStyleBackColor = true;
            // 
            // hot_dog
            // 
            hot_dog.AutoSize = true;
            hot_dog.Location = new  Point(28, 49);
            hot_dog.Name = "hot_dog";
            hot_dog.Size = new  Size(67, 17);
            hot_dog.TabIndex = 13;
            hot_dog.Text = "Хот-Дог";
            hot_dog.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle =  BorderStyle.Fixed3D;
            panel2.Controls.Add(this.cafe_panel_rezult_txt);
            panel2.Controls.Add(this.label2);
            panel2.Controls.Add(this.cafe_panel_rezult_mony);
            panel2.Location = new  Point(10, 255);
            panel2.Name = "panel2";
            panel2.Size = new  Size(261, 100);
            panel2.TabIndex = 12;
            // 
            // cafe_panel_rezult_txt
            // 
            cafe_panel_rezult_txt.AutoSize = true;
            cafe_panel_rezult_txt.Font = new  Font("Microsoft Sans Serif", 8F,  FontStyle.Regular,  GraphicsUnit.Point, ((byte)(204)));
            cafe_panel_rezult_txt.ForeColor =  SystemColors.Highlight;
            cafe_panel_rezult_txt.Location = new  Point(3, 0);
            cafe_panel_rezult_txt.Name = "cafe_panel_rezult_txt";
            cafe_panel_rezult_txt.Size = new  Size(52, 13);
            cafe_panel_rezult_txt.TabIndex = 14;
            cafe_panel_rezult_txt.Text = "К оплате";
            cafe_panel_rezult_txt.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor =  SystemColors.Desktop;
            label2.Location = new  Point(215, 70);
            label2.Name = "label2";
            label2.Size = new  Size(24, 13);
            label2.TabIndex = 13;
            label2.Text = "грн";
            label2.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // cafe_panel_rezult_mony
            // 
            cafe_panel_rezult_mony.Font = new  Font("Microsoft Sans Serif", 25F,  FontStyle.Regular,  GraphicsUnit.Point, ((byte)(204)));
            cafe_panel_rezult_mony.ForeColor =  SystemColors.ControlText;
            cafe_panel_rezult_mony.Location = new  Point(85, 23);
            cafe_panel_rezult_mony.Name = "cafe_panel_rezult_mony";
            cafe_panel_rezult_mony.Size = new  Size(124, 60);
            cafe_panel_rezult_mony.TabIndex = 13;
            cafe_panel_rezult_mony.Text = "0";
            cafe_panel_rezult_mony.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // cafe_panel_name
            // 
            cafe_panel_name.AutoSize = true;
            cafe_panel_name.ForeColor =  SystemColors.Highlight;
            cafe_panel_name.Location = new  Point(3, -1);
            cafe_panel_name.Name = "cafe_panel_name";
            cafe_panel_name.Size = new  Size(34, 13);
            cafe_panel_name.TabIndex = 0;
            cafe_panel_name.Text = "Кафе";
            // 
            // rezult_panel
            // 
            rezult_panel.BorderStyle =  BorderStyle.Fixed3D;
            rezult_panel.Controls.Add(this.label3);
            rezult_panel.Controls.Add(this.rezult_price);
            rezult_panel.Controls.Add(this.label1);
            rezult_panel.Controls.Add(this.butt_rezult);
            rezult_panel.Location = new  Point(12, 414);
            rezult_panel.Name = "rezult_panel";
            rezult_panel.Size = new  Size(623, 132);
            rezult_panel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new  Font("Microsoft Sans Serif", 8F,  FontStyle.Regular,  GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor =  SystemColors.Highlight;
            label3.Location = new  Point(5, 0);
            label3.Name = "label3";
            label3.Size = new  Size(52, 13);
            label3.TabIndex = 15;
            label3.Text = "К оплате";
            label3.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // rezult_price
            // 
            rezult_price.Font = new  Font("Microsoft Sans Serif", 25F,  FontStyle.Regular,  GraphicsUnit.Point, ((byte)(204)));
            rezult_price.ForeColor =  SystemColors.ControlText;
            rezult_price.Location = new  Point(422, 16);
            rezult_price.Name = "rezult_price";
            rezult_price.Size = new  Size(128, 102);
            rezult_price.TabIndex = 16;
            rezult_price.Text = "0";
            rezult_price.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.ForeColor =  SystemColors.Desktop;
            label1.Location = new  Point(552, 56);
            label1.Name = "label1";
            label1.Size = new  Size(63, 37);
            label1.TabIndex = 15;
            label1.Text = "грн";
            label1.TextAlign =  ContentAlignment.MiddleCenter;
            // 
            // butt_rezult
            // 
            butt_rezult.BackColor =  SystemColors.ControlLight;
            butt_rezult.Font = new  Font("Microsoft Sans Serif", 16F,  FontStyle.Bold,  GraphicsUnit.Point, ((byte)(204)));
            butt_rezult.Location = new  Point(85, 16);
            butt_rezult.Name = "butt_rezult";
            butt_rezult.Size = new  Size(321, 105);
            butt_rezult.TabIndex = 0;
            butt_rezult.Text = "ПОСЧИТАТЬ";
            butt_rezult.UseVisualStyleBackColor = false;
            // 
            // Best_Oli
            // 
            AutoScaleDimensions = new  SizeF(6F, 13F);
            AutoScaleMode =  AutoScaleMode.Font;
            AutoSize = true;
            BackColor =  SystemColors.ActiveBorder;
            ClientSize = new  Size(647, 556);
            Controls.Add(this.rezult_panel);
            Controls.Add(this.panel_cafe);
            Controls.Add(this.panel_gass);
            FormBorderStyle =  FormBorderStyle.FixedDialog;
            Name = "Best_Oli";
            Text = "Best Oli";
            panel_gass.ResumeLayout(false);
            panel_gass.PerformLayout();
            gass_panel_rezult.ResumeLayout(false);
            gass_panel_rezult.PerformLayout();
            gass_panel_radio.ResumeLayout(false);
            gass_panel_radio.PerformLayout();
            panel_cafe.ResumeLayout(false);
            panel_cafe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_potato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_hot)).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            rezult_panel.ResumeLayout(false);
            rezult_panel.PerformLayout();
            ResumeLayout(false);

        }







        #endregion

       
    }
}

