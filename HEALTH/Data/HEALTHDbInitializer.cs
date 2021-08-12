using HEALTH.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HEALTH.Data
{
    public static class HEALTHDbInitializer
    {
        // fonction Initializa
        public static void Initialize(HEALTHDbContext myContext)
        {
            myContext.Database.EnsureCreated();

            if (myContext.Caisses.Any())
            {
                return;
            }

            var caisses = new Caisse[]
            {
                new Caisse{NomCaisse="Caisse 1"},
                new Caisse{NomCaisse="Caisse 2"},
                new Caisse{NomCaisse="Caisse 3"}
            };

            foreach (Caisse c in caisses)
            {
                myContext.Caisses.Add(c);
            }
            myContext.SaveChanges();

            var categories = new Categorie[]
            {
                new Categorie{Libelle = "Douleurs", Description="Medicaments pour soigner les douleurs"},
                new Categorie{Libelle = "Vitamines", Description="Compléments nutritionnels"},
                new Categorie{Libelle = "Analgésique", Description="Medicaments analgésiques"},
                new Categorie{Libelle = "Anti-biotiques", Description="Medicaments pour le traitement en anti-biotiques"}
            };
            foreach (Categorie cat in categories)
            {
                myContext.Categories.Add(cat);
            }
            myContext.SaveChanges();

            var profils = new Profil[]
            {
                new Profil{Libelle = "Administrateur"},
                new Profil{Libelle = "Caissier"},
                new Profil{Libelle = "Pharmacien"},
                new Profil{Libelle = "Medecin"},
                new Profil{Libelle = "Docteur"},
                new Profil{Libelle = "Aide-soignant"},
                new Profil{Libelle = "Sage-femme"}
            };
            foreach (Profil p in profils)
            {
                myContext.Profils.Add(p);
            }
            myContext.SaveChanges();

            var typeSoins = new TypeSoin[]
            {
                new TypeSoin{Libelle = "Hemato"},
                new TypeSoin{Libelle = "Chirurgie"},
                new TypeSoin{Libelle = "Pédiatrie"},
                new TypeSoin{Libelle = "Dentaire"},
                new TypeSoin{Libelle = "Consultation"}
            };
            foreach (TypeSoin ts in typeSoins)
            {
                myContext.TypeSoins.Add(ts);
            }
            myContext.SaveChanges();

            var users = new User[]
            {
                new User{Nom = "GBENYON", Prenom ="Pierre", Adresse="Lomé TOGO", Login="GBEN", Password ="mypassword", firstUse="true", Profil_ID =1},
                new User{Nom = "ALIOU", Prenom ="Noel", Adresse="Lomé TOGO", Login="ALIOU", Password ="mypassword", firstUse="true", Profil_ID =2},
                new User{Nom = "JOSET", Prenom ="Eunice", Adresse="Lomé TOGO", Login="JOSET", Password ="mypassword", firstUse="true", Profil_ID =2},
                new User{Nom = "VAGBLI", Prenom ="Hélène", Adresse="Lomé TOGO", Login="VAGBLI", Password ="mypassword", firstUse="true", Profil_ID =3},
                new User{Nom = "ABAPO", Prenom ="Logovi", Adresse="Lomé TOGO", Login="ABAPO", Password ="mypassword", firstUse="true", Profil_ID =4},
                new User{Nom = "VODOUA", Prenom ="Blaise", Adresse="Lomé TOGO", Login="VODOUA", Password ="mypassword", firstUse="true", Profil_ID =5},
                new User{Nom = "KPEVIKA", Prenom ="Alain", Adresse="Lomé TOGO", Login="KPEVIKA", Password ="mypassword", firstUse="true", Profil_ID =6},
                new User{Nom = "VIBOU", Prenom ="Hollande", Adresse="Lomé TOGO", Login="VIBOU", Password ="mypassword", firstUse="true", Profil_ID =7},
            };
            foreach (User u in users)
            {
                myContext.Users.Add(u);
            }
            myContext.SaveChanges();

            var soins = new Soin[]
            {
                new Soin{Libelle = "Vasetomie", Cout = 80000, Type_ID = 2},
                new Soin{Libelle = "Dialyse", Cout = 140000, Type_ID = 1},
                new Soin{Libelle = "Consultation prénatale", Cout = 4000, Type_ID = 5},
            };
            foreach (Soin s in soins)
            {
                myContext.Soins.Add(s);
            }
            myContext.SaveChanges();

            var produits = new Produit[]
            {
                new Produit{Designation = "Paracetamol", QteStock = 52 , Prix = 4000 , Seuil = 30 , Categorie_ID = 1},
                new Produit{Designation = "Vtamina C20", QteStock = 19 , Prix = 1000 , Seuil = 10 , Categorie_ID = 2},
                new Produit{Designation = "Nivakine", QteStock = 23 , Prix = 3000 , Seuil = 15 , Categorie_ID = 3},
                new Produit{Designation = "Amaril 400mg", QteStock = 8 , Prix = 2000 , Seuil = 10 , Categorie_ID = 4}
            };
            foreach (Produit p in produits)
            {
                myContext.Produits.Add(p);
            }
            myContext.SaveChanges();

            var prestations = new Prestation[]
            {
                new Prestation{Libelle = "Prestation du patient X" },
                new Prestation{Libelle = "Prestation du patient Y" },
                new Prestation{Libelle = "Prestation du patient Z" }
            };
            foreach (Prestation p in prestations)
            {
                myContext.Prestations.Add(p);
            }
            myContext.SaveChanges();

            var prestationsSoins = new PrestationSoin[]
            {
                new PrestationSoin{ Prestation_ID=2, Soin_ID = 1 , NbreSoin = 1  },
                new PrestationSoin{ Prestation_ID=2, Soin_ID = 2 , NbreSoin = 1  }, //220000

                new PrestationSoin{ Prestation_ID=3, Soin_ID = 3 , NbreSoin = 4  }, // 16000
            };
            foreach (PrestationSoin ps in prestationsSoins)
            {
                myContext.PrestationSoins.Add(ps);
            }
            myContext.SaveChanges();

            var prestationsProduits = new PrestationProduit[]
            {
                new PrestationProduit{ Prestation_ID=2, Produit_ID = 1 , Qte = 3  },
                new PrestationProduit{ Prestation_ID=2, Produit_ID = 2 , Qte = 1  }, // Prestation 2 : 13000

                new PrestationProduit{ Prestation_ID=3, Produit_ID = 3 , Qte = 3  } //9000
            };
            foreach (PrestationProduit pp in prestationsProduits)
            {
                myContext.PrestationProduits.Add(pp);
            }
            myContext.SaveChanges();

            var caisseOperations = new CaisseOperation[]
{
                new CaisseOperation{Libelle = "La Caisse N°1 ouverte le "+DateTime.Today.ToShortDateString() , FondCaisse =20000, Solde = 33000 , Caisse_ID =1 },
                new CaisseOperation{Libelle = "La Caisse N°2 ouverte le "+DateTime.Today.ToShortDateString() , FondCaisse =15000, Solde = 13000 , Caisse_ID =2 },
};
            foreach (CaisseOperation cOpe in caisseOperations)
            {
                myContext.CaisseOperations.Add(cOpe);
            }
            myContext.SaveChanges();

            var paiements = new Paiement[]
            {
                new Paiement{Libelle = "Paiement du patient X" , CaisseOperation_ID =1 , Prestation_ID = 1 , DatePaie= DateTime.Today, Solde = 8000}, //8000
                new Paiement{Libelle = "Paiement du patient Y" , CaisseOperation_ID =2 , Prestation_ID = 2, DatePaie= DateTime.Today, Solde = 13000}, //13000
                new Paiement{Libelle = "Paiement du patient Z" , CaisseOperation_ID =1 , Prestation_ID = 3, DatePaie= DateTime.Today, Solde = 25000} //25000
            };
            foreach (Paiement p in paiements)
            {
                myContext.Paiements.Add(p);
            }
            myContext.SaveChanges();

            var affectationCaisses = new AffectationCaisse[]
            {
                new AffectationCaisse{User_ID =2, CaisseOperation_ID =1 , dateAffectation = DateTime.Today },
                new AffectationCaisse{User_ID =3, CaisseOperation_ID =2 , dateAffectation = DateTime.Today }
            };
            foreach (AffectationCaisse ac in affectationCaisses)
            {
                myContext.AffectationCaisses.Add(ac);
            }
            myContext.SaveChanges();
        }
    }
}
