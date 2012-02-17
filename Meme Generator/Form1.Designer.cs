namespace WindowsFormsApplication2
{
    partial class MemeMaker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemeMaker));
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_change_font = new System.Windows.Forms.Button();
            this.font_dialog_box = new System.Windows.Forms.FontDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_upload = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toptext_label = new System.Windows.Forms.Label();
            this.bottext_label = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_clr_text = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(252, 335);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 23);
            this.btn_right.TabIndex = 2;
            this.btn_right.Text = "---->";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(12, 335);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 3;
            this.btn_left.Text = "<----";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_change_font
            // 
            this.btn_change_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_font.Location = new System.Drawing.Point(374, 146);
            this.btn_change_font.Name = "btn_change_font";
            this.btn_change_font.Size = new System.Drawing.Size(169, 34);
            this.btn_change_font.TabIndex = 4;
            this.btn_change_font.Text = "Change Font";
            this.btn_change_font.UseVisualStyleBackColor = true;
            this.btn_change_font.Click += new System.EventHandler(this.btn_change_font_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "insanity blank.jpg");
            this.imageList1.Images.SetKeyName(1, "philosoraptor.jpg");
            this.imageList1.Images.SetKeyName(2, "images.jpg");
            this.imageList1.Images.SetKeyName(3, "forever-alone.jpg");
            // 
            // btn_upload
            // 
            this.btn_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(374, 186);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(169, 32);
            this.btn_upload.TabIndex = 5;
            this.btn_upload.Text = "Upload Picture";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(428, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // toptext_label
            // 
            this.toptext_label.AutoSize = true;
            this.toptext_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toptext_label.Location = new System.Drawing.Point(333, 24);
            this.toptext_label.Name = "toptext_label";
            this.toptext_label.Size = new System.Drawing.Size(66, 18);
            this.toptext_label.TabIndex = 8;
            this.toptext_label.Text = "Top Text";
            // 
            // bottext_label
            // 
            this.bottext_label.AutoSize = true;
            this.bottext_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottext_label.Location = new System.Drawing.Point(333, 50);
            this.bottext_label.Name = "bottext_label";
            this.bottext_label.Size = new System.Drawing.Size(89, 18);
            this.bottext_label.TabIndex = 9;
            this.bottext_label.Text = "Bottom Text";
            // 
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Location = new System.Drawing.Point(398, 252);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(118, 40);
            this.btn_generate.TabIndex = 10;
            this.btn_generate.Text = "Save";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*" +
                "";
            this.openFileDialog1.Title = "Open an Image";
            // 
            // btn_clr_text
            // 
            this.btn_clr_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_clr_text.Location = new System.Drawing.Point(374, 106);
            this.btn_clr_text.Name = "btn_clr_text";
            this.btn_clr_text.Size = new System.Drawing.Size(169, 34);
            this.btn_clr_text.TabIndex = 14;
            this.btn_clr_text.Text = "Clear Text";
            this.btn_clr_text.UseVisualStyleBackColor = true;
            this.btn_clr_text.Click += new System.EventHandler(this.btn_clr_text_Click_1);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            this.saveFileDialog1.Title = "Save an Image File";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MemeMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_clr_text);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.bottext_label);
            this.Controls.Add(this.toptext_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.btn_change_font);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Name = "MemeMaker";
            this.Text = "Meme Generator";
            this.Load += new System.EventHandler(this.MemeMaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_change_font;
        private System.Windows.Forms.FontDialog font_dialog_box;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label toptext_label;
        private System.Windows.Forms.Label bottext_label;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_clr_text;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

