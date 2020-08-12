namespace Time_Tracker_Form
{
    partial class AthleteLaps
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
            this.athleteListLabel = new System.Windows.Forms.Label();
            this.richTextBoxForReport = new System.Windows.Forms.RichTextBox();
            this.listBoxForAtheleteTimes = new System.Windows.Forms.ListBox();
            this.richTextBoxForAthleteNames = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // athleteListLabel
            // 
            this.athleteListLabel.AutoSize = true;
            this.athleteListLabel.Location = new System.Drawing.Point(12, 135);
            this.athleteListLabel.Name = "athleteListLabel";
            this.athleteListLabel.Size = new System.Drawing.Size(76, 13);
            this.athleteListLabel.TabIndex = 1;
            this.athleteListLabel.Text = "List of Athletes";
            // 
            // richTextBoxForReport
            // 
            this.richTextBoxForReport.Location = new System.Drawing.Point(210, 10);
            this.richTextBoxForReport.Name = "richTextBoxForReport";
            this.richTextBoxForReport.Size = new System.Drawing.Size(379, 418);
            this.richTextBoxForReport.TabIndex = 0;
            this.richTextBoxForReport.Text = "";
            this.richTextBoxForReport.TextChanged += new System.EventHandler(this.reportTextBox_TextChanged);
            // 
            // listBoxForAtheleteTimes
            // 
            this.listBoxForAtheleteTimes.FormattingEnabled = true;
            this.listBoxForAtheleteTimes.Location = new System.Drawing.Point(11, 151);
            this.listBoxForAtheleteTimes.Name = "listBoxForAtheleteTimes";
            this.listBoxForAtheleteTimes.Size = new System.Drawing.Size(179, 186);
            this.listBoxForAtheleteTimes.TabIndex = 1;
            this.listBoxForAtheleteTimes.SelectedIndexChanged += new System.EventHandler(this.listBoxForAtheleteTimes_SelectedIndexChanged);
            // 
            // richTextBoxForAthleteNames
            // 
            this.richTextBoxForAthleteNames.Location = new System.Drawing.Point(12, 10);
            this.richTextBoxForAthleteNames.Name = "richTextBoxForAthleteNames";
            this.richTextBoxForAthleteNames.Size = new System.Drawing.Size(178, 49);
            this.richTextBoxForAthleteNames.TabIndex = 2;
            this.richTextBoxForAthleteNames.Text = "Please choose an Athlete below to see their lap times in the textbox on the right" +
    ".";
            this.richTextBoxForAthleteNames.TextChanged += new System.EventHandler(this.richTextBoxForAthleteNames_TextChanged);
            // 
            // AthleteLaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.richTextBoxForAthleteNames);
            this.Controls.Add(this.listBoxForAtheleteTimes);
            this.Controls.Add(this.richTextBoxForReport);
            this.Controls.Add(this.athleteListLabel);
            this.Name = "AthleteLaps";
            this.Text = "AthleteTimes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label athleteListLabel;
        private System.Windows.Forms.RichTextBox richTextBoxForReport;
        private System.Windows.Forms.ListBox listBoxForAtheleteTimes;
        private System.Windows.Forms.RichTextBox richTextBoxForAthleteNames;
    }
}