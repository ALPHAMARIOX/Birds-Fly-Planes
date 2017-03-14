namespace NWAL_FLIGHT_PLAN
{
    partial class frmMain
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
            this.tbcFlight = new System.Windows.Forms.TabControl();
            this.tbpFlightPlan = new System.Windows.Forms.TabPage();
            this.tbpFlightPlan2 = new System.Windows.Forms.TabPage();
            this.tbcFlight.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcFlight
            // 
            this.tbcFlight.Controls.Add(this.tbpFlightPlan);
            this.tbcFlight.Controls.Add(this.tbpFlightPlan2);
            this.tbcFlight.Location = new System.Drawing.Point(-1, -2);
            this.tbcFlight.Name = "tbcFlight";
            this.tbcFlight.SelectedIndex = 0;
            this.tbcFlight.Size = new System.Drawing.Size(1174, 633);
            this.tbcFlight.TabIndex = 0;
            // 
            // tbpFlightPlan
            // 
            this.tbpFlightPlan.Location = new System.Drawing.Point(4, 22);
            this.tbpFlightPlan.Name = "tbpFlightPlan";
            this.tbpFlightPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFlightPlan.Size = new System.Drawing.Size(1166, 607);
            this.tbpFlightPlan.TabIndex = 0;
            this.tbpFlightPlan.Text = "Flight Plan";
            this.tbpFlightPlan.UseVisualStyleBackColor = true;
            // 
            // tbpFlightPlan2
            // 
            this.tbpFlightPlan2.Location = new System.Drawing.Point(4, 22);
            this.tbpFlightPlan2.Name = "tbpFlightPlan2";
            this.tbpFlightPlan2.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFlightPlan2.Size = new System.Drawing.Size(1166, 607);
            this.tbpFlightPlan2.TabIndex = 1;
            this.tbpFlightPlan2.Text = "tabPage2";
            this.tbpFlightPlan2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 629);
            this.Controls.Add(this.tbcFlight);
            this.Name = "frmMain";
            this.Text = "NWAL Flight Plan Program";
            this.tbcFlight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcFlight;
        private System.Windows.Forms.TabPage tbpFlightPlan;
        private System.Windows.Forms.TabPage tbpFlightPlan2;
    }
}

