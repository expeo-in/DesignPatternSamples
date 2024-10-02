using DesignPatternSamples.Behavioral.Mediator.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Behavioral.Mediator.SolutionUsingObserver
{
    internal class ArticleDialogBox
    {
        private ListBox articlesListBox;
        private TextBox titleTextBox;
        private Button saveButton;

        public ArticleDialogBox()
        {
            articlesListBox = new ListBox();
            articlesListBox.AddEventHandler(ArticleSelected);

            titleTextBox = new TextBox();
            titleTextBox.AddEventHandler(TitleChanged);

            saveButton = new Button();
        }

        public void SimulateUserInteraction()
        {
            articlesListBox.Selection = "Article1";
            titleTextBox.Content = "";
            Console.WriteLine(titleTextBox.Content);
            Console.WriteLine(saveButton.IsEnabled);

        }

        private void ArticleSelected()
        {
            titleTextBox.Content = articlesListBox.Selection;
            saveButton.IsEnabled = true;
        }

        private void TitleChanged()
        {
            var content = titleTextBox.Content;
            saveButton.IsEnabled = !String.IsNullOrEmpty(content);
        }
    }
}
