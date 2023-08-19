namespace pixelwashgui
{
    partial class mainwindow
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
            this.preview = new System.Windows.Forms.PictureBox();
            this.openfile = new System.Windows.Forms.Button();
            this.savefile = new System.Windows.Forms.Button();
            this.lengthtrack = new System.Windows.Forms.TrackBar();
            this.randomnesstrack = new System.Windows.Forms.TrackBar();
            this.randomness = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.randomnessvalue = new System.Windows.Forms.TextBox();
            this.lengthvalue = new System.Windows.Forms.TextBox();
            this.anglevalue = new System.Windows.Forms.TextBox();
            this.angle = new System.Windows.Forms.TextBox();
            this.angletrack = new System.Windows.Forms.TrackBar();
            this.executebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthtrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomnesstrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angletrack)).BeginInit();
            this.SuspendLayout();
            // 
            // preview
            // 
            this.preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preview.BackColor = System.Drawing.SystemColors.ControlDark;
            this.preview.Image = global::pixelwashgui.Properties.Resources.tempwash;
            this.preview.ImageLocation = "";
            this.preview.Location = new System.Drawing.Point(174, 12);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(878, 657);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.preview.TabIndex = 0;
            this.preview.TabStop = false;
            this.preview.Click += new System.EventHandler(this.preview_Click);
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(12, 12);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(75, 23);
            this.openfile.TabIndex = 1;
            this.openfile.Text = "open file";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openfile_MouseClick);
            // 
            // savefile
            // 
            this.savefile.Location = new System.Drawing.Point(93, 12);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(75, 23);
            this.savefile.TabIndex = 2;
            this.savefile.Text = "save file";
            this.savefile.UseVisualStyleBackColor = true;
            this.savefile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.savefile_MouseClick);
            // 
            // lengthtrack
            // 
            this.lengthtrack.Location = new System.Drawing.Point(12, 130);
            this.lengthtrack.Maximum = 500;
            this.lengthtrack.Name = "lengthtrack";
            this.lengthtrack.Size = new System.Drawing.Size(156, 45);
            this.lengthtrack.SmallChange = 50;
            this.lengthtrack.TabIndex = 3;
            this.lengthtrack.TickFrequency = 50;
            this.lengthtrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.lengthtrack.ValueChanged += new System.EventHandler(this.lengthtrack_ValueChanged);
            // 
            // randomnesstrack
            // 
            this.randomnesstrack.Location = new System.Drawing.Point(12, 60);
            this.randomnesstrack.Maximum = 100;
            this.randomnesstrack.Name = "randomnesstrack";
            this.randomnesstrack.Size = new System.Drawing.Size(156, 45);
            this.randomnesstrack.SmallChange = 10;
            this.randomnesstrack.TabIndex = 4;
            this.randomnesstrack.TickFrequency = 10;
            this.randomnesstrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.randomnesstrack.ValueChanged += new System.EventHandler(this.randomnesstrack_ValueChanged);
            // 
            // randomness
            // 
            this.randomness.BackColor = System.Drawing.SystemColors.Control;
            this.randomness.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.randomness.Location = new System.Drawing.Point(12, 41);
            this.randomness.Name = "randomness";
            this.randomness.Size = new System.Drawing.Size(75, 13);
            this.randomness.TabIndex = 5;
            this.randomness.Text = "randomness";
            this.randomness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // length
            // 
            this.length.BackColor = System.Drawing.SystemColors.Control;
            this.length.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.length.Location = new System.Drawing.Point(12, 111);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(75, 13);
            this.length.TabIndex = 6;
            this.length.Text = "length";
            this.length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // randomnessvalue
            // 
            this.randomnessvalue.BackColor = System.Drawing.SystemColors.Control;
            this.randomnessvalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.randomnessvalue.Location = new System.Drawing.Point(93, 41);
            this.randomnessvalue.Name = "randomnessvalue";
            this.randomnessvalue.Size = new System.Drawing.Size(75, 13);
            this.randomnessvalue.TabIndex = 7;
            this.randomnessvalue.Text = "0";
            this.randomnessvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lengthvalue
            // 
            this.lengthvalue.BackColor = System.Drawing.SystemColors.Control;
            this.lengthvalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lengthvalue.Location = new System.Drawing.Point(93, 111);
            this.lengthvalue.Name = "lengthvalue";
            this.lengthvalue.Size = new System.Drawing.Size(75, 13);
            this.lengthvalue.TabIndex = 8;
            this.lengthvalue.Text = "0";
            this.lengthvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // anglevalue
            // 
            this.anglevalue.BackColor = System.Drawing.SystemColors.Control;
            this.anglevalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anglevalue.Location = new System.Drawing.Point(93, 181);
            this.anglevalue.Name = "anglevalue";
            this.anglevalue.Size = new System.Drawing.Size(75, 13);
            this.anglevalue.TabIndex = 11;
            this.anglevalue.Text = "0";
            this.anglevalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // angle
            // 
            this.angle.BackColor = System.Drawing.SystemColors.Control;
            this.angle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.angle.Location = new System.Drawing.Point(12, 181);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(75, 13);
            this.angle.TabIndex = 10;
            this.angle.Text = "angle";
            this.angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // angletrack
            // 
            this.angletrack.Location = new System.Drawing.Point(12, 200);
            this.angletrack.Maximum = 359;
            this.angletrack.Name = "angletrack";
            this.angletrack.Size = new System.Drawing.Size(156, 45);
            this.angletrack.SmallChange = 15;
            this.angletrack.TabIndex = 9;
            this.angletrack.TickFrequency = 45;
            this.angletrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.angletrack.ValueChanged += new System.EventHandler(this.angletrack_ValueChanged);
            // 
            // executebutton
            // 
            this.executebutton.Location = new System.Drawing.Point(12, 251);
            this.executebutton.Name = "executebutton";
            this.executebutton.Size = new System.Drawing.Size(75, 23);
            this.executebutton.TabIndex = 12;
            this.executebutton.Text = "execute";
            this.executebutton.UseVisualStyleBackColor = true;
            this.executebutton.Click += new System.EventHandler(this.executebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(93, 251);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 13;
            this.updatebutton.Text = "update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.executebutton);
            this.Controls.Add(this.anglevalue);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.angletrack);
            this.Controls.Add(this.lengthvalue);
            this.Controls.Add(this.randomnessvalue);
            this.Controls.Add(this.length);
            this.Controls.Add(this.randomness);
            this.Controls.Add(this.randomnesstrack);
            this.Controls.Add(this.lengthtrack);
            this.Controls.Add(this.savefile);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.preview);
            this.Name = "mainwindow";
            this.Text = "pixelwash";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthtrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomnesstrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angletrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Button savefile;
        private System.Windows.Forms.TrackBar lengthtrack;
        private System.Windows.Forms.TrackBar randomnesstrack;
        private System.Windows.Forms.TextBox randomness;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox randomnessvalue;
        private System.Windows.Forms.TextBox lengthvalue;
        private System.Windows.Forms.TextBox anglevalue;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.TrackBar angletrack;
        private System.Windows.Forms.Button executebutton;
        private System.Windows.Forms.Button updatebutton;
    }
}

