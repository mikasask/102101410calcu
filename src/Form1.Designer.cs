using System.Security.Cryptography.X509Certificates;

namespace calcu
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
        public void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            xsd = new Button();
            button0 = new Button();
            yu = new Button();
            button7 = new Button();
            button9 = new Button();
            button8 = new Button();
            dy = new Button();
            sub = new Button();
            mul = new Button();
            add = new Button();
            ac = new Button();
            div = new Button();
            fh = new Button();
            del = new Button();
            op = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(188, 405);
            button1.Name = "button1";
            button1.Size = new Size(92, 97);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += numbutton_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(329, 405);
            button2.Name = "button2";
            button2.Size = new Size(92, 97);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += numbutton_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonShadow;
            button3.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(462, 405);
            button3.Name = "button3";
            button3.Size = new Size(92, 97);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += numbutton_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonShadow;
            button4.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(188, 293);
            button4.Name = "button4";
            button4.Size = new Size(92, 97);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += numbutton_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonShadow;
            button5.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(329, 293);
            button5.Name = "button5";
            button5.Size = new Size(92, 97);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += numbutton_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonShadow;
            button6.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(462, 293);
            button6.Name = "button6";
            button6.Size = new Size(92, 97);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += numbutton_Click;
            // 
            // xsd
            // 
            xsd.BackColor = SystemColors.ButtonShadow;
            xsd.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            xsd.Location = new Point(462, 521);
            xsd.Name = "xsd";
            xsd.Size = new Size(92, 97);
            xsd.TabIndex = 11;
            xsd.Text = ".";
            xsd.UseVisualStyleBackColor = false;
            xsd.Click += xsd_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ButtonShadow;
            button0.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(329, 521);
            button0.Name = "button0";
            button0.Size = new Size(92, 97);
            button0.TabIndex = 0;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += numbutton_Click;
            // 
            // yu
            // 
            yu.BackColor = SystemColors.ButtonShadow;
            yu.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            yu.Location = new Point(188, 521);
            yu.Name = "yu";
            yu.Size = new Size(92, 97);
            yu.TabIndex = 9;
            yu.Text = "%";
            yu.UseVisualStyleBackColor = false;
            yu.Click += cbutton_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonShadow;
            button7.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(188, 177);
            button7.Name = "button7";
            button7.Size = new Size(92, 97);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += numbutton_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonShadow;
            button9.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(462, 177);
            button9.Name = "button9";
            button9.Size = new Size(92, 97);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += numbutton_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonShadow;
            button8.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(329, 177);
            button8.Name = "button8";
            button8.Size = new Size(92, 97);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += numbutton_Click;
            // 
            // dy
            // 
            dy.BackColor = SystemColors.ButtonShadow;
            dy.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            dy.Location = new Point(652, 521);
            dy.Name = "dy";
            dy.Size = new Size(92, 97);
            dy.TabIndex = 15;
            dy.Text = "=";
            dy.UseVisualStyleBackColor = false;
            dy.Click += dy_Click;
            // 
            // sub
            // 
            sub.BackColor = SystemColors.ButtonShadow;
            sub.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            sub.Location = new Point(652, 177);
            sub.Name = "sub";
            sub.Size = new Size(92, 97);
            sub.TabIndex = 14;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = false;
            sub.Click += cbutton_Click;
            // 
            // mul
            // 
            mul.BackColor = SystemColors.ButtonShadow;
            mul.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            mul.Location = new Point(652, 293);
            mul.Name = "mul";
            mul.Size = new Size(92, 97);
            mul.TabIndex = 13;
            mul.Text = "*";
            mul.UseVisualStyleBackColor = false;
            mul.Click += cbutton_Click;
            // 
            // add
            // 
            add.BackColor = SystemColors.ButtonShadow;
            add.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(652, 405);
            add.Name = "add";
            add.Size = new Size(92, 97);
            add.TabIndex = 12;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            add.Click += cbutton_Click;
            // 
            // ac
            // 
            ac.BackColor = SystemColors.ButtonShadow;
            ac.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ac.Location = new Point(53, 521);
            ac.Name = "ac";
            ac.Size = new Size(92, 97);
            ac.TabIndex = 19;
            ac.Text = "AC";
            ac.UseVisualStyleBackColor = false;
            ac.Click += ac_Click;
            // 
            // div
            // 
            div.BackColor = SystemColors.ButtonShadow;
            div.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            div.Location = new Point(53, 177);
            div.Name = "div";
            div.Size = new Size(92, 97);
            div.TabIndex = 18;
            div.Text = "/";
            div.UseVisualStyleBackColor = false;
            div.Click += cbutton_Click;
            // 
            // fh
            // 
            fh.BackColor = SystemColors.ButtonShadow;
            fh.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            fh.Location = new Point(53, 293);
            fh.Name = "fh";
            fh.Size = new Size(92, 97);
            fh.TabIndex = 17;
            fh.Text = "+/-";
            fh.UseVisualStyleBackColor = false;
            fh.Click += fh_Click;
            // 
            // del
            // 
            del.BackColor = SystemColors.ButtonShadow;
            del.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point);
            del.Location = new Point(53, 405);
            del.Name = "del";
            del.Size = new Size(92, 97);
            del.TabIndex = 16;
            del.Text = "×";
            del.UseVisualStyleBackColor = false;
            del.Click += del_Click;
            // 
            // op
            // 
            op.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            op.BackColor = SystemColors.ActiveCaption;
            op.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            op.ImageAlign = ContentAlignment.BottomRight;
            op.Location = new Point(53, 28);
            op.Name = "op";
            op.Size = new Size(691, 118);
            op.TabIndex = 20;
            op.TextAlign = ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 639);
            Controls.Add(op);
            Controls.Add(ac);
            Controls.Add(div);
            Controls.Add(fh);
            Controls.Add(del);
            Controls.Add(dy);
            Controls.Add(sub);
            Controls.Add(mul);
            Controls.Add(add);
            Controls.Add(xsd);
            Controls.Add(button0);
            Controls.Add(yu);
            Controls.Add(button7);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        //本来这里都是private,但是单元测试一直访问不了就全改成public了
        public Button button1;
        public Button button2;
        public Button button3;
        public Button button4;
        public Button button5;
        public Button button6;
        public Button xsd;
        public Button button0;
        public Button yu;
        public Button button7;
        public Button button9;
        public Button button8;
        public Button dy;
        public Button sub;
        public Button mul;
        public Button add;
        public Button ac;
        public Button div;
        public Button fh;
        public Button del;
        public Label op;
    }
}