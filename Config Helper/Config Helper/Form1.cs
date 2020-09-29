using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Config_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Text Editor

        private void UpdateTextEditor()
        {
            var configFeatureID =
                !string.IsNullOrEmpty(txtConfigFeature.Text) ? "DECLARE @ConfigFeatureID INT = NULL\r\n" : string.Empty;

            var configAttributeID = !string.IsNullOrEmpty(txtConfigAttributeFeature.Text)
                ? "DECLARE @ConfigAttributeID INT = NULL\r\n" : string.Empty;

            var declareSection = !string.IsNullOrEmpty(configFeatureID) ? configFeatureID + (!string.IsNullOrEmpty(configAttributeID) ? configAttributeID : string.Empty) + "\r\n" : string.Empty;

            var configFeatureText = !string.IsNullOrEmpty(txtConfigFeature.Text)
                ? "\tINSERT INTO ConfigFeature([DisplayName])\r\n\t\t" +
                  "SELECT '" + txtConfigFeature.Text + "'\r\n\t\t" +
                  "WHERE NOT EXISTS (\r\n\t\t\t" +
                  "SELECT * FROM ConfigFeature WHERE [DisplayName] = '" + txtConfigFeature.Text + "')\r\n\r\n\t" +
                  "SELECT @ConfigFeatureID = [ConfigFeatureID]\r\n\t" +
                  "FROM ConfigFeature\r\n\t" +
                  "WHERE [DisplayName] = '" + txtConfigFeature.Text + "'" : string.Empty;

            var configFeatureState = !string.IsNullOrEmpty(txtUSState.Text)
                ?
                "\r\n\r\n\tINSERT INTO ConfigStateFeature([USState], [ConfigFeatureID])\r\n\t\t" +
                "SELECT '" + txtUSState.Text + "', @ConfigFeatureID\r\n\t\t" +
                "WHERE NOT EXISTS (\r\n\t\t\t" +
                "SELECT * FROM ConfigStateFeature WHERE [ConfigFeatureID] = @ConfigFeatureID)"
                : string.Empty;

            var configAttributeText = !string.IsNullOrEmpty(txtConfigAttributeFeature.Text)
                ? "\r\n\r\n\tINSERT INTO ConfigAttribute([DisplayName])\r\n\t\t" +
                  "SELECT '" + txtConfigAttributeFeature.Text + "'\r\n\t\t" +
                  "WHERE NOT EXISTS (\r\n\t\t\t" +
                  "SELECT * FROM ConfigAttribute WHERE [DisplayName] = '" + txtConfigAttributeFeature.Text + "')\r\n\r\n\t" +
                  "SELECT @ConfigAttributeID = [ConfigAttributeID]\r\n\t" +
                  "FROM ConfigAttribute\r\n\t" +
                  "WHERE [DisplayName] = '" + txtConfigAttributeFeature.Text + "'" : string.Empty;

            var configAttributeItemColumns = !string.IsNullOrEmpty(configAttributeText) ? "ConfigAttributeID" + (
                    !string.IsNullOrEmpty(txtTagName.Text) ? ", [TagName]" : string.Empty) + (
                    cmbAttributes.SelectedIndex != -1 ? ", [Attribute]" : string.Empty) + (
                    !string.IsNullOrEmpty(txtValue.Text) ? ", [Value]" : string.Empty)
                : string.Empty;

            var configAttributeItemSelect = !string.IsNullOrEmpty(configAttributeText)
                ? "@ConfigAttributeID" + (
                    !string.IsNullOrEmpty(txtTagName.Text) ? ", '" + txtTagName.Text + "'" : string.Empty) + (
                    cmbAttributes.SelectedIndex != -1 ? ", '" + cmbAttributes.Text + "'" : string.Empty) + (
                    !string.IsNullOrEmpty(txtValue.Text) ? ", '" + txtValue.Text + "'" : string.Empty)
                : string.Empty;

            var configAttributeItemWhere = !string.IsNullOrEmpty(configAttributeText)
                ? "[ConfigAttributeID] = @ConfigAttributeID" +
                  (!string.IsNullOrEmpty(txtTagName.Text)
                      ? "\r\n\t\t\t\tAND [TagName] = '" + txtTagName.Text + "'"
                      : string.Empty) +
                  (!string.IsNullOrEmpty(cmbAttributes.Text)
                      ? "\r\n\t\t\t\tAND [Attribute] = '" + cmbAttributes.Text + "'"
                      : string.Empty) +
                  (!string.IsNullOrEmpty(txtValue.Text)
                      ? "\r\n\t\t\t\tAND [Value] = '" + txtValue.Text + "'"
                      : string.Empty)
                : string.Empty;

            var configAttributeItemText = !string.IsNullOrEmpty(configAttributeText)
                ? "\r\n\r\n\t" +
                  "INSERT INTO ConfigAttributeItem(" + configAttributeItemColumns + ")\r\n\t\t" +
                  "SELECT " + configAttributeItemSelect + "\r\n\t\t" +
                  "WHERE NOT EXISTS (\r\n\t\t\t" +
                  "SELECT * \r\n\t\t\t" +
                  "FROM ConfigAttributeItem\r\n\t\t\t" +
                  "WHERE " + configAttributeItemWhere + ")"
                : string.Empty;

            var configItemColumns = !string.IsNullOrEmpty(configFeatureID)
                ? "[ConfigFeatureID], [Path]" +
                  (!string.IsNullOrEmpty(txtShow.Text) ? ", [Show]" : string.Empty) +
                  (!string.IsNullOrEmpty(txtHide.Text) ? ", [Hide]" : string.Empty) +
                  (!string.IsNullOrEmpty(txtDropDown.Text) ? ", [DropDown]" : string.Empty) +
                  (!string.IsNullOrEmpty(configAttributeID) ? ", [ConfigAttributeID]" : string.Empty) +
                  (!string.IsNullOrEmpty(txtCourtCategory.Text) ? ", [CourtCategory]" : string.Empty)
                : string.Empty;

            var configItemsSelect = !string.IsNullOrEmpty(configFeatureID)
                ? "@ConfigFeatureID, '" + txtPath.Text + "'" +
                  (!string.IsNullOrEmpty(txtShow.Text) ? ", '" + txtShow.Text + "'" : string.Empty) +
                  (!string.IsNullOrEmpty(txtHide.Text) ? ", '" + txtHide.Text + "'" : string.Empty) +
                  (!string.IsNullOrEmpty(txtDropDown.Text) ? ", '" + txtDropDown.Text + "'" : string.Empty) +
                  (!string.IsNullOrEmpty(configAttributeID) ? ", @ConfigAttributeID" : string.Empty) +
                  (!string.IsNullOrEmpty(txtCourtCategory.Text) ? ", '" + txtCourtCategory.Text + "'" : string.Empty)
                : string.Empty;

            var configItemWhere = !string.IsNullOrEmpty(configFeatureID)
                ? "[ConfigFeatureID] = @ConfigFeatureID" +
                  "\r\n\t\t\t\tAND [Path] = '" + txtPath.Text + "'" +
                  (!string.IsNullOrEmpty(txtShow.Text) 
                      ? "\r\n\t\t\t\tAND [Show] = '" + txtShow.Text + "'" 
                      : string.Empty) +
                  (!string.IsNullOrEmpty(txtHide.Text) 
                      ? "\r\n\t\t\t\tAND [Hide] = '" + txtHide.Text + "'" 
                      : string.Empty) +
                  (!string.IsNullOrEmpty(txtDropDown.Text) 
                      ? "\r\n\t\t\t\tAND [DropDown] = '" + txtDropDown.Text + "'" 
                      : string.Empty) +
                  (!string.IsNullOrEmpty(configAttributeID) 
                      ? "\r\n\t\t\t\tAND [ConfigAttributeID] = @ConfigAttributeID" 
                      : string.Empty) +
                  (!string.IsNullOrEmpty(txtCourtCategory.Text) 
                      ? "\r\n\t\t\t\tAND [CourtCategory] = '" + txtCourtCategory.Text + "'" 
                      : string.Empty)
                : string.Empty;


            var configItem = !string.IsNullOrEmpty(configFeatureID)
                ? "\r\n\r\n\t" +
                  "INSERT INTO ConfigItem(" + configItemColumns + ")\r\n\t\t" +
                  "SELECT " + configItemsSelect + "\r\n\t\t" +
                  "WHERE NOT EXISTS (\r\n\t\t\t" +
                  "SELECT * \r\n\t\t\t" +
                  "FROM ConfigItem\r\n\t\t\t" +
                  "WHERE " + configItemWhere + ")"
                : string.Empty;

            txtEditor.Text = declareSection + "BEGIN\r\n" +
                             configFeatureText +
                             configFeatureState +
                             configAttributeText +
                             configAttributeItemText +
                             configItem +
                             "\r\nEND";

        }

        #endregion

        #region Path Textbox
        private void txtPath_Enter(object sender, EventArgs e)
        {
            txtPath.Clear();
            txtPath.Focus();
        }
        #endregion

        #region Check US State is 2 Characters
        private void txtUSState_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtUSState.TextLength > 2)
            {
                MessageBox.Show("US State Must Be 2 Characters", "Config Helper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUSState.Clear();
                txtUSState.Focus();
            }
            else
            {
                UpdateTextEditor();
            }
        }
        #endregion

        #region Quick Select
        private void cmbQuickSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetBackColors();

            switch (cmbQuickSelect.Text)
            {
                case "Add a Feature":
                    txtConfigFeature.BackColor = Color.Yellow;
                    txtConfigFeature.Focus();
                    break;
                case "Show a Feature":
                    txtConfigFeature.BackColor = Color.Yellow;
                    txtShow.BackColor = Color.Yellow;
                    txtConfigFeature.Focus();
                    break;
                case "Hide a Feature":
                    txtConfigFeature.BackColor = Color.Yellow;
                    txtHide.BackColor = Color.Yellow;
                    txtConfigFeature.Focus();
                    break;
                case "Add an Attribute":
                    txtConfigAttributeFeature.BackColor = Color.Yellow;
                    txtTagName.BackColor = Color.Yellow;
                    cmbAttributes.BackColor = Color.Yellow;
                    txtValue.BackColor = Color.Yellow;
                    txtConfigAttributeFeature.Focus();
                    break;
                default:
                    ResetFields();
                    ResetBackColors();
                    break;
            }
        }
        #endregion

        #region Clear Text and Reset Combo Boxes
        private void ResetFields()
        {
            cmbQuickSelect.SelectedIndex = -1;
            txtConfigFeature.Clear();
            txtConfigAttributeFeature.Clear();
            txtUSState.Clear();
            txtPath.Text = "/folder/filename.aspx";
            txtShow.Clear();
            txtHide.Clear();
            txtDropDown.Clear();
            txtCourtCategory.Clear();
            txtTagName.Clear();
            cmbAttributes.SelectedIndex = -1;
            txtValue.Clear();
            txtEditor.Clear();
            ckbxAdult.Checked = false;
            ckbxVeteran.Checked = false;
            ckbxJuvenile.Checked = false;
            ckbxTribal.Checked = false;
            ckbxMentalHealth.Checked = false;
            ckbxFamilyDependency.Checked = false;
        }
        #endregion

        #region Reset Color to White
        private void ResetBackColors()
        {
            txtConfigFeature.BackColor = Color.White;
            txtConfigAttributeFeature.BackColor = Color.White;
            txtUSState.BackColor = Color.White;
            txtShow.BackColor = Color.White;
            txtHide.BackColor = Color.White;
            txtDropDown.BackColor = Color.White;
            txtCourtCategory.BackColor = Color.White;
            txtTagName.BackColor = Color.White;
            cmbAttributes.BackColor = Color.White;
            txtValue.BackColor = Color.White;
        }
        #endregion

        #region Reset Button
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ResetFields();
            ResetBackColors();
        }
        #endregion

        #region Clipboard
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "/folder/filename.aspx" || string.IsNullOrEmpty(txtPath.Text))
            {
                MessageBox.Show("Path is Required", "Config Helper", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPath.Focus();
            }
            Clipboard.Clear();
            Clipboard.SetText(txtEditor.Text);
        }

        #endregion

        private void txtConfigFeature_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateTextEditor();
        }

        private void txtConfigAttributeFeature_KeyUp(object sender, KeyEventArgs e)
        {
            txtConfigFeature.Text = txtConfigAttributeFeature.Text;
            if (!string.IsNullOrEmpty(txtConfigAttributeFeature.Text)) UnlockAttributes();
            else LockAttributes();
            UpdateTextEditor();
        }

        private void UnlockAttributes()
        {
            txtTagName.Enabled = true;
            cmbAttributes.Enabled = true;
            txtValue.Enabled = true;
        }

        private void LockAttributes()
        {
            txtTagName.Enabled = false;
            cmbAttributes.Enabled = false;
            txtValue.Enabled = false;
        }

        private void txtTagName_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateTextEditor();
        }

        private void cmbAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbAttributes.Text)
            {
                case "courtcategory":
                    txtValue.Text = txtCourtCategory.Text;
                    break;
                case "data-required":
                    txtValue.Text = "true or false";
                    break;
                case "data-shownodes":
                    txtValue.Text = "Enter Nodes; @Replace('Node Name',''); @Append('&A=Node1,Node2,Node3,...Node(n)')";
                    break;
                case "dbtype":
                    txtValue.Text = string.Empty;
                    break;
                case "id":
                    txtValue.Text = "Enter attribute ID";
                    break;
                case "innerHTML":
                    txtValue.Text = "Enter Inner HTML text";
                    break;
                case "name":
                    txtValue.Text = "Enter attribute name";
                    break;
                case "onClick":
                    txtValue.Text = "Enter javascript function";
                    break;
                case "ShowNodes":
                    txtValue.Text =
                        "SelectOptionValue1=NodeToShow1,NodeToShow2,...NodeToShow(n)&SelectOptionValue2=NodeToShow3,NodeToShow4,...NodeToShow(x)";
                    break;
                case "style":
                    txtValue.Text = "display:none";
                    break;
                case "title":
                    txtValue.Text = "Title Text";
                    break;
                case "value":
                    txtValue.Text = "Enter value";
                    break;
                default:
                    txtValue.Text = string.Empty;
                    break;
            }
            UpdateTextEditor();
        }

        private void txtValue_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateTextEditor();
        }

        #region Court Category
        private void UpdateCourtCategoryText()
        {
            txtCourtCategory.Clear();

            List<string> courts = new List<string>();
            if (ckbxAdult.Checked) courts.Add("A");
            else courts.Remove("A");

            if (ckbxVeteran.Checked) courts.Add("V");
            else courts.Remove("V");

            if (ckbxJuvenile.Checked) courts.Add("J");
            else courts.Remove("J");

            if (ckbxTribal.Checked) courts.Add("T");
            else courts.Remove("T");

            if (ckbxMentalHealth.Checked) courts.Add("S");
            else courts.Remove("S");

            if (ckbxFamilyDependency.Checked) courts.Add("F");
            else courts.Remove("F");

            if (courts.Count > 1)
            {
                foreach (var court in courts)
                {
                    txtCourtCategory.Text += court + ",";
                }

                txtCourtCategory.Text = txtCourtCategory.Text.Substring(0, txtCourtCategory.Text.Length - 1);
            }
            else
            {
                txtCourtCategory.Text = courts.FirstOrDefault();
            }

            UpdateTextEditor();
        }

        private void ckbxAdult_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCourtCategoryText();
        }

        private void ckbxVeteran_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCourtCategoryText();
        }

        private void ckbxJuvenile_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCourtCategoryText();
        }

        private void ckbxTribal_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCourtCategoryText();
        }

        private void ckbxMentalHealth_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCourtCategoryText();
        }

        private void ckbxFamilyDependency_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCourtCategoryText();
        }
        #endregion

        private void txtPath_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateTextEditor();
        }

        private void txtShow_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateTextEditor();
        }

        private void txtHide_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateTextEditor();
        }

        private void txtDropDown_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateTextEditor();
        }
    }
}
