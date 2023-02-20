namespace MusicStore.Web.Models;

public class Cart
{
    public List<CartLine> Lines { get; set; } = new List<CartLine>();

    public void AddItem(Product product, int quantity)
    { 
        CartLine? line = Lines.Where(item=>item.Product.ProductId == product.ProductId).FirstOrDefault();
        if(line == null) 
            Lines.Add(new CartLine() { Product = product, Quantity = quantity });       
        else 
            line.Quantity += quantity; 
    }

    public void RemoveLine(Product product)
        => Lines.RemoveAll(item => item.Product.ProductId == product.ProductId);

    public decimal ComputeTotalValue() => Lines.Sum(item=>item.Product.Price * item.Quantity);

    public void Clear() => Lines.Clear();
}               
