
namespace HelloWorldGUI
{
	partial class HelloWorldForm
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
			this.hwTextLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// hwTextLabel
			// 
			this.hwTextLabel.AutoSize = true;
			this.hwTextLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.hwTextLabel.Location = new System.Drawing.Point(38, 94);
			this.hwTextLabel.Name = "hwTextLabel";
			this.hwTextLabel.Size = new System.Drawing.Size(206, 45);
			this.hwTextLabel.TabIndex = 0;
			this.hwTextLabel.Text = "Hello, World!";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.hwTextLabel);
			this.Name = "Form1";
			this.Text = "Hello, World!";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label hwTextLabel;
	}
}

