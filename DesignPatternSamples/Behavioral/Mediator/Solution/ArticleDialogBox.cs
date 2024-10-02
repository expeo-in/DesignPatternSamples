using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Mediator.Solution
{
    internal class ArticleDialogBox : DialogBox
    {
        private ListBox articlesListBox;
        private TextBox titleTextBox;
        private Button saveButton;

        public ArticleDialogBox()
        {
            articlesListBox =  new ListBox(this);
            titleTextBox = new TextBox(this);
            saveButton = new Button(this);
        }

        public void SimulateUserInteraction()
        {
            articlesListBox.Selection = "Article1";
            //titleTextBox.Content = "";
            Console.WriteLine(titleTextBox.Content);
            Console.WriteLine(saveButton.IsEnabled);

        }

        public override void Changed(UIControl control)
        {
            if (control == articlesListBox)
                articleSelected();
            else if(control == titleTextBox)
                titleChanged();
        }

        private void articleSelected()
        {
            titleTextBox.Content = articlesListBox.Selection;
            saveButton.IsEnabled = true;
        }

        private void titleChanged()
        {
            var content = titleTextBox.Content;
            saveButton.IsEnabled = !String.IsNullOrEmpty(content);
        }
    }
}
