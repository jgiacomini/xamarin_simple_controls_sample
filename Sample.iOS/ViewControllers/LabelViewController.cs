using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Sample.iOS.ViewControllers
{
    public class LabelViewController : UIViewController
    {
        public LabelViewController()
        {
			Title = "Libellé";

			View.BackgroundColor = UIColor.White;
			this.EdgesForExtendedLayout = UIRectEdge.None;

			// couleurs personalisée
			// les couleurs et l'alpha doivent être une valeur comprise entre 0.0 et 1.0
			nfloat rouge = 0.92f;
			nfloat vert = 0.32f;
			nfloat bleu = 0.32f;
			nfloat alpha = 1;
			var maCouleur = new UIColor(rouge, vert, bleu, alpha);


			var monLabel = new UILabel();
            monLabel.Frame = new CGRect(10, 10, View.Bounds.Width - 20, 40);
			monLabel.Text = "Affiche un texte simple";
            monLabel.TextColor = maCouleur;
            monLabel.AdjustsFontSizeToFitWidth = true;


	
			var monLabelLigneMultiple = new UILabel();
            monLabelLigneMultiple.Frame = new CGRect(10, 60, View.Bounds.Width - 20, 80);
            monLabelLigneMultiple.Lines = 0;
			monLabelLigneMultiple.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non risus. Suspendisse lectus tortor, dignissim sit amet, adipiscing nec, ultricies sed, dolor. Cras elementum ultrices diam. Maecenas ligula massa, varius a, semper congue, euismod non, mi. Proin porttitor, orci nec nonummy molestie, enim est eleifend mi, non fermentum diam nisl sit amet erat. Duis semper. Duis arcu massa, scelerisque vitae, consequat in, pretium a, enim. Pellentesque congue. Ut in risus volutpat libero pharetra tempor. Cras vestibulum bibendum augue. Praesent egestas leo in pede. Praesent blandit odio eu enim. Pellentesque sed dui ut augue blandit sodales. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aliquam nibh. Mauris ac mauris sed pede pellentesque fermentum. Maecenas adipiscing ante non diam sodales hendrerit.";
            monLabelLigneMultiple.TextColor = UIColor.Black;
            monLabelLigneMultiple.LineBreakMode = UILineBreakMode.MiddleTruncation;

			// Ajoute le label à la vue principale
            View.AddSubviews(monLabel, monLabelLigneMultiple);


			nfloat tailleDeLaPolice = 15f;
			string nomDeLaPolice = "Helvetica";
			string monTexte = "Texte à mesurer";
			var font = UIFont.FromName(nomDeLaPolice, tailleDeLaPolice);

            // Création de la classe NSString à partir de l'instance de monTexte
            var nsString = new NSString(monTexte);
			CGSize tailleCalculee = nsString.StringSize(font);
            Console.WriteLine($"Largeur : {tailleCalculee.Width}, hauteur : {tailleCalculee.Height}");
		}
    }
}
