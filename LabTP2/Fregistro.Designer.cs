namespace LabTP2
{
    partial class Fregistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fregistro));
            this.lBregistro = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lBregistro
            // 
            this.lBregistro.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lBregistro.FormattingEnabled = true;
            this.lBregistro.ItemHeight = 16;
            this.lBregistro.Location = new System.Drawing.Point(41, 28);
            this.lBregistro.Name = "lBregistro";
            this.lBregistro.Size = new System.Drawing.Size(287, 324);
            this.lBregistro.TabIndex = 0;
            // 
            // Fregistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::LabTP2.Properties.Resources.ciudad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 400);
            this.Controls.Add(this.lBregistro);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fregistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fregistro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBregistro;
    }
}