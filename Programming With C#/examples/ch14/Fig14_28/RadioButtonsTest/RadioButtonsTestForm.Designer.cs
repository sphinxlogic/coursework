namespace RadioButtonsTest
{
   partial class RadioButtonsTestForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.displayLabel = new System.Windows.Forms.Label();
         this.displayButton = new System.Windows.Forms.Button();
         this.iconTypeGroupBox = new System.Windows.Forms.GroupBox();
         this.warningRadioButton = new System.Windows.Forms.RadioButton();
         this.stopRadioButton = new System.Windows.Forms.RadioButton();
         this.handRadioButton = new System.Windows.Forms.RadioButton();
         this.asteriskRadioButton = new System.Windows.Forms.RadioButton();
         this.questionRadioButton = new System.Windows.Forms.RadioButton();
         this.informationRadioButton = new System.Windows.Forms.RadioButton();
         this.exclamationRadioButton = new System.Windows.Forms.RadioButton();
         this.errorRadioButton = new System.Windows.Forms.RadioButton();
         this.buttonTypeGroupBox = new System.Windows.Forms.GroupBox();
         this.retryCancelRadioButton = new System.Windows.Forms.RadioButton();
         this.yesNoRadioButton = new System.Windows.Forms.RadioButton();
         this.yesNoCancelRadioButton = new System.Windows.Forms.RadioButton();
         this.abortRetryIgnoreRadioButton = new System.Windows.Forms.RadioButton();
         this.okCancelRadioButton = new System.Windows.Forms.RadioButton();
         this.okRadioButton = new System.Windows.Forms.RadioButton();
         this.iconTypeGroupBox.SuspendLayout();
         this.buttonTypeGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // displayLabel
         // 
         this.displayLabel.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.displayLabel.Location = new System.Drawing.Point( 26, 358 );
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size( 189, 20 );
         this.displayLabel.TabIndex = 26;
         // 
         // displayButton
         // 
         this.displayButton.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.displayButton.Location = new System.Drawing.Point( 48, 306 );
         this.displayButton.Name = "displayButton";
         this.displayButton.Size = new System.Drawing.Size( 129, 38 );
         this.displayButton.TabIndex = 25;
         this.displayButton.Text = "Display";
         this.displayButton.Click += new System.EventHandler( this.displayButton_Click );
         // 
         // iconTypeGroupBox
         // 
         this.iconTypeGroupBox.Controls.Add( this.warningRadioButton );
         this.iconTypeGroupBox.Controls.Add( this.stopRadioButton );
         this.iconTypeGroupBox.Controls.Add( this.handRadioButton );
         this.iconTypeGroupBox.Controls.Add( this.asteriskRadioButton );
         this.iconTypeGroupBox.Controls.Add( this.questionRadioButton );
         this.iconTypeGroupBox.Controls.Add( this.informationRadioButton );
         this.iconTypeGroupBox.Controls.Add( this.exclamationRadioButton );
         this.iconTypeGroupBox.Controls.Add( this.errorRadioButton );
         this.iconTypeGroupBox.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.iconTypeGroupBox.Location = new System.Drawing.Point( 235, 27 );
         this.iconTypeGroupBox.Name = "iconTypeGroupBox";
         this.iconTypeGroupBox.Size = new System.Drawing.Size( 160, 351 );
         this.iconTypeGroupBox.TabIndex = 24;
         this.iconTypeGroupBox.TabStop = false;
         this.iconTypeGroupBox.Text = "Icon";
         // 
         // warningRadioButton
         // 
         this.warningRadioButton.AutoSize = true;
         this.warningRadioButton.Location = new System.Drawing.Point( 19, 305 );
         this.warningRadioButton.Name = "warningRadioButton";
         this.warningRadioButton.Size = new System.Drawing.Size( 70, 19 );
         this.warningRadioButton.TabIndex = 15;
         this.warningRadioButton.Text = "Warning";
         this.warningRadioButton.CheckedChanged += new System.EventHandler( this.iconType_CheckedChanged );
         // 
         // stopRadioButton
         // 
         this.stopRadioButton.AutoSize = true;
         this.stopRadioButton.Location = new System.Drawing.Point( 19, 269 );
         this.stopRadioButton.Name = "stopRadioButton";
         this.stopRadioButton.Size = new System.Drawing.Size( 49, 19 );
         this.stopRadioButton.TabIndex = 14;
         this.stopRadioButton.Text = "Stop";
         this.stopRadioButton.CheckedChanged += new System.EventHandler( this.iconType_CheckedChanged );
         // 
         // handRadioButton
         // 
         this.handRadioButton.AutoSize = true;
         this.handRadioButton.Location = new System.Drawing.Point( 19, 151 );
         this.handRadioButton.Name = "handRadioButton";
         this.handRadioButton.Size = new System.Drawing.Size( 54, 19 );
         this.handRadioButton.TabIndex = 13;
         this.handRadioButton.Text = "Hand";
         this.handRadioButton.CheckedChanged += new System.EventHandler( this.iconType_CheckedChanged );
         // 
         // asteriskRadioButton
         // 
         this.asteriskRadioButton.AutoSize = true;
         this.asteriskRadioButton.Location = new System.Drawing.Point( 19, 31 );
         this.asteriskRadioButton.Name = "asteriskRadioButton";
         this.asteriskRadioButton.Size = new System.Drawing.Size( 66, 19 );
         this.asteriskRadioButton.TabIndex = 12;
         this.asteriskRadioButton.Text = "Asterisk";
         this.asteriskRadioButton.CheckedChanged += new System.EventHandler( this.iconType_CheckedChanged );
         // 
         // questionRadioButton
         // 
         this.questionRadioButton.AutoSize = true;
         this.questionRadioButton.Location = new System.Drawing.Point( 19, 232 );
         this.questionRadioButton.Name = "questionRadioButton";
         this.questionRadioButton.Size = new System.Drawing.Size( 73, 19 );
         this.questionRadioButton.TabIndex = 11;
         this.questionRadioButton.Text = "Question";
         this.questionRadioButton.CheckedChanged += new System.EventHandler( this.iconType_CheckedChanged );
         // 
         // informationRadioButton
         // 
         this.informationRadioButton.AutoSize = true;
         this.informationRadioButton.Location = new System.Drawing.Point( 19, 193 );
         this.informationRadioButton.Name = "informationRadioButton";
         this.informationRadioButton.Size = new System.Drawing.Size( 88, 19 );
         this.informationRadioButton.TabIndex = 10;
         this.informationRadioButton.Text = "Information";
         this.informationRadioButton.CheckedChanged += new System.EventHandler( this.iconType_CheckedChanged );
         // 
         // exclamationRadioButton
         // 
         this.exclamationRadioButton.AutoSize = true;
         this.exclamationRadioButton.Location = new System.Drawing.Point( 19, 110 );
         this.exclamationRadioButton.Name = "exclamationRadioButton";
         this.exclamationRadioButton.Size = new System.Drawing.Size( 89, 19 );
         this.exclamationRadioButton.TabIndex = 9;
         this.exclamationRadioButton.Text = "Exclamation";
         this.exclamationRadioButton.CheckedChanged += new System.EventHandler( this.iconType_CheckedChanged );
         // 
         // errorRadioButton
         // 
         this.errorRadioButton.AutoSize = true;
         this.errorRadioButton.Location = new System.Drawing.Point( 19, 70 );
         this.errorRadioButton.Name = "errorRadioButton";
         this.errorRadioButton.Size = new System.Drawing.Size( 50, 19 );
         this.errorRadioButton.TabIndex = 8;
         this.errorRadioButton.Text = "Error";
         this.errorRadioButton.CheckedChanged += new System.EventHandler( this.iconType_CheckedChanged );
         // 
         // buttonTypeGroupBox
         // 
         this.buttonTypeGroupBox.Controls.Add( this.retryCancelRadioButton );
         this.buttonTypeGroupBox.Controls.Add( this.yesNoRadioButton );
         this.buttonTypeGroupBox.Controls.Add( this.yesNoCancelRadioButton );
         this.buttonTypeGroupBox.Controls.Add( this.abortRetryIgnoreRadioButton );
         this.buttonTypeGroupBox.Controls.Add( this.okCancelRadioButton );
         this.buttonTypeGroupBox.Controls.Add( this.okRadioButton );
         this.buttonTypeGroupBox.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.buttonTypeGroupBox.Location = new System.Drawing.Point( 29, 27 );
         this.buttonTypeGroupBox.Name = "buttonTypeGroupBox";
         this.buttonTypeGroupBox.Size = new System.Drawing.Size( 189, 265 );
         this.buttonTypeGroupBox.TabIndex = 23;
         this.buttonTypeGroupBox.TabStop = false;
         this.buttonTypeGroupBox.Text = "Button Type";
         // 
         // retryCancelRadioButton
         // 
         this.retryCancelRadioButton.AutoSize = true;
         this.retryCancelRadioButton.Location = new System.Drawing.Point( 19, 232 );
         this.retryCancelRadioButton.Name = "retryCancelRadioButton";
         this.retryCancelRadioButton.Size = new System.Drawing.Size( 88, 19 );
         this.retryCancelRadioButton.TabIndex = 6;
         this.retryCancelRadioButton.Text = "RetryCancel";
         this.retryCancelRadioButton.CheckedChanged += new System.EventHandler( this.buttonType_CheckedChanged );
         // 
         // yesNoRadioButton
         // 
         this.yesNoRadioButton.AutoSize = true;
         this.yesNoRadioButton.Location = new System.Drawing.Point( 19, 193 );
         this.yesNoRadioButton.Name = "yesNoRadioButton";
         this.yesNoRadioButton.Size = new System.Drawing.Size( 59, 19 );
         this.yesNoRadioButton.TabIndex = 5;
         this.yesNoRadioButton.Text = "YesNo";
         this.yesNoRadioButton.CheckedChanged += new System.EventHandler( this.buttonType_CheckedChanged );
         // 
         // yesNoCancelRadioButton
         // 
         this.yesNoCancelRadioButton.AutoSize = true;
         this.yesNoCancelRadioButton.Location = new System.Drawing.Point( 19, 151 );
         this.yesNoCancelRadioButton.Name = "yesNoCancelRadioButton";
         this.yesNoCancelRadioButton.Size = new System.Drawing.Size( 95, 19 );
         this.yesNoCancelRadioButton.TabIndex = 4;
         this.yesNoCancelRadioButton.Text = "YesNoCancel";
         this.yesNoCancelRadioButton.CheckedChanged += new System.EventHandler( this.buttonType_CheckedChanged );
         // 
         // abortRetryIgnoreRadioButton
         // 
         this.abortRetryIgnoreRadioButton.AutoSize = true;
         this.abortRetryIgnoreRadioButton.Location = new System.Drawing.Point( 19, 110 );
         this.abortRetryIgnoreRadioButton.Name = "abortRetryIgnoreRadioButton";
         this.abortRetryIgnoreRadioButton.Size = new System.Drawing.Size( 116, 19 );
         this.abortRetryIgnoreRadioButton.TabIndex = 3;
         this.abortRetryIgnoreRadioButton.Text = "AbortRetryIgnore";
         this.abortRetryIgnoreRadioButton.CheckedChanged += new System.EventHandler( this.buttonType_CheckedChanged );
         // 
         // okCancelRadioButton
         // 
         this.okCancelRadioButton.AutoSize = true;
         this.okCancelRadioButton.Location = new System.Drawing.Point( 19, 70 );
         this.okCancelRadioButton.Name = "okCancelRadioButton";
         this.okCancelRadioButton.Size = new System.Drawing.Size( 77, 19 );
         this.okCancelRadioButton.TabIndex = 2;
         this.okCancelRadioButton.Text = "OKCancel";
         this.okCancelRadioButton.CheckedChanged += new System.EventHandler( this.buttonType_CheckedChanged );
         // 
         // okRadioButton
         // 
         this.okRadioButton.AutoSize = true;
         this.okRadioButton.Location = new System.Drawing.Point( 19, 31 );
         this.okRadioButton.Name = "okRadioButton";
         this.okRadioButton.Size = new System.Drawing.Size( 41, 19 );
         this.okRadioButton.TabIndex = 1;
         this.okRadioButton.Text = "OK";
         this.okRadioButton.CheckedChanged += new System.EventHandler( this.buttonType_CheckedChanged );
         // 
         // RadioButtonsTestForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 421, 405 );
         this.Controls.Add( this.displayLabel );
         this.Controls.Add( this.displayButton );
         this.Controls.Add( this.iconTypeGroupBox );
         this.Controls.Add( this.buttonTypeGroupBox );
         this.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.Name = "RadioButtonsTestForm";
         this.Text = "Demonstrating RadioButtons";
         this.iconTypeGroupBox.ResumeLayout( false );
         this.iconTypeGroupBox.PerformLayout();
         this.buttonTypeGroupBox.ResumeLayout( false );
         this.buttonTypeGroupBox.PerformLayout();
         this.ResumeLayout( false );

      }

      #endregion

      internal System.Windows.Forms.Label displayLabel;
      internal System.Windows.Forms.Button displayButton;
      internal System.Windows.Forms.GroupBox iconTypeGroupBox;
      internal System.Windows.Forms.RadioButton warningRadioButton;
      internal System.Windows.Forms.RadioButton stopRadioButton;
      internal System.Windows.Forms.RadioButton handRadioButton;
      internal System.Windows.Forms.RadioButton asteriskRadioButton;
      internal System.Windows.Forms.RadioButton questionRadioButton;
      internal System.Windows.Forms.RadioButton informationRadioButton;
      internal System.Windows.Forms.RadioButton exclamationRadioButton;
      internal System.Windows.Forms.RadioButton errorRadioButton;
      internal System.Windows.Forms.GroupBox buttonTypeGroupBox;
      internal System.Windows.Forms.RadioButton retryCancelRadioButton;
      internal System.Windows.Forms.RadioButton yesNoRadioButton;
      internal System.Windows.Forms.RadioButton yesNoCancelRadioButton;
      internal System.Windows.Forms.RadioButton abortRetryIgnoreRadioButton;
      internal System.Windows.Forms.RadioButton okCancelRadioButton;
      internal System.Windows.Forms.RadioButton okRadioButton;



   }
}