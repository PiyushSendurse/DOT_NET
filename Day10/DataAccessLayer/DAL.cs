namespace DataAccessLayer;
using BusinessObjectLayer;
public class DBManager
{
    public static List<Product> GetAllProducts(){
        List<Product> allProducts= new List<Product>();
        allProducts.Add(new Product {Id=5, Title=" The Great Gatsby by F. Scott Fitzgerald",Category="Book",Description="""The novel chronicles an era that Fitzgerald himself dubbed the "Jazz Age". Following the shock and chaos of World War I, American society enjoyed unprecedented levels of prosperity""",UnitPrice=950,Balance=2500});
        allProducts.Add(new Product {Id=6, Title=" Moby Dick by Herman Melville",Category="Book",Description="""First published in 1851, Melville's masterpiece is, in Elizabeth Hardwick's words, "the greatest novel in American literature."""",UnitPrice=350,Balance=2500});
        allProducts.Add(new Product {Id=4, Title=" One Hundred Years of Solitude by Gabriel Garcia Marquez",Category="Book",Description="One of the 20th century's enduring works, One Hundred Years of Solitude is a widely beloved and acclaimed novel known throughout the world, and the ultimate achievement in a Nobel Prize",UnitPrice=800,Balance=2500});
        allProducts.Add(new Product {Id=7, Title=" War and Peace by Leo Tolstoy",Category="Book",Description="Epic in scale, War and Peace delineates in graphic detail events leading up to Napoleon's invasion of Russia, and the impact of the Napoleonic era on Tsarist society",UnitPrice=750,Balance=2500});
        allProducts.Add(new Product {Id=3, Title=" Don Quixote by Miguel de Cervantes",Category="Book",Description="Alonso Quixano, a retired country gentleman in his fifties, lives in an unnamed section of La Mancha with his niece and a housekeeper.",UnitPrice=550,Balance=2500});
        allProducts.Add(new Product {Id=8, Title=" Hamlet by William Shakespeare",Category="Book",Description="The Tragedy of Hamlet, Prince of Denmark, or more simply Hamlet, is a tragedy by William Shakespeare, believed to have been written between 1599 and 1601.",UnitPrice=700,Balance=2500});
        allProducts.Add(new Product {Id=2, Title=" Ulysses by James Joyce",Category="Book",Description="Ulysses chronicles the passage of Leopold Bloom through Dublin during an ordinary day, June 16, 1904. ",UnitPrice=600,Balance=2500});
        allProducts.Add(new Product {Id=9, Title=" The Odyssey by Homer",Category="Book",Description="The Odyssey is one of two major ancient Greek epic poems attributed to Homer. It is, in part, a sequel to the Iliad, the other work traditionally ascribed to Homer. ",UnitPrice=1100,Balance=2500});
        allProducts.Add(new Product {Id=10, Title=" Madame Bovary by Gustave Flaubert",Category="Book",Description="""For daring to peer into the heart of an adulteress and enumerate its contents with profound dispassion, the author of Madame Bovary was tried for "offenses against morality and religion."""",UnitPrice=650,Balance=2500});
        allProducts.Add(new Product {Id=1, Title=" In Search of Lost Time by Marcel Proust",Category="Book",Description="Swann's Way, the first part of A la recherche de temps perdu, Marcel Proust's seven-part cycle, was published in 1913. In it, Proust introduces the themes that run through the entire work. ",UnitPrice=500,Balance=2500});
        
        return allProducts;
    }
}
