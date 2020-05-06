SELECT P.Product, C.Categorie FROM Products AS P 
LEFT JOIN Categories_in_Products AS CP ON P.Id_Product = CP.Id_Product 
LEFT JOIN Categories AS C ON CP.Id_Categorie = C.Id_Categorie
