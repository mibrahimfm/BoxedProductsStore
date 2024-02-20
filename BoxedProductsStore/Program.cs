using BoxedProductsStore;

IPackage product1 = new Product(10, 5);
IPackage product2 = new Product(15, 2);
IPackage product3 = new Product(20, 3);
IPackage product4 = new Product(50, 1);
IPackage product5 = new Product(1, 15);
IPackage box1 = new Box();
IPackage box2 = new Box();

((Box)box2).AddContent(product1);
((Box)box2).AddContent(product2);
((Box)box2).AddContent(product3);
((Box)box1).AddContent(product4);
((Box)box1).AddContent(product5);
((Box)box1).AddContent(box2);

Console.WriteLine($"Total cost of the package: {box1.Calculate():F2}");