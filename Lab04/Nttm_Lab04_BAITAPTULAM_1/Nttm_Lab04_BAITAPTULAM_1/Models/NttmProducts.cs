using Nttm_Lab04_BAITAPTULAM_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Nttm_Lab04_BAITAPTULAM_1.Models
{
    public class NttmProducts
    {
        public string ProductId { get; set; }   
        public string ProductName { get; set; }
        public string ProductUnit {  get; set; }
        public int ProductPrice { get; set; }
    }
    // định nghĩa giao diện thực đơn 
    public interface NttmIProductsRespository { 
        // khai báo phương thức lấy danh sách thực đơn 
        IList<NttmProducts> NttmGetProducts();
        // khai báo phương thức lấy thực đơn 
        NttmProducts NttmGetProducts(string productId);
        //khai báo phương thức thêm khách hàng
        void NttmAddCustomer(NttmProducts cus);
        //khai báo phương thức cập nhật khách hàng
        void NttmUpdateCustomer(NttmProducts cus);
        //khai báo phương thức tìm kiếm khách hàng
        IList<NttmProducts> NttmSearchCustomer(string name);
        //khai báo phương thức xóa khách hàng
        void NttmDeleteCustomer(NttmProducts cus);
    }
}
public class NttmProductRespository : NttmIProductsRespository
{
    private readonly string _filePath;

    public NttmProductRespository()
    {
        _filePath = HttpContext.Current.Server.MapPath("~/App_Data/NttmProducts.xml");
    }
    public IList<NttmProducts> NttmGetProducts()
    {
        var doc = XDocument.Load(_filePath);
        var products = from product in doc.Descendants("Product")
                       select new NttmProducts
                       {
                           ProductId = product.Element("ProductId").Value,
                           ProductName = product.Element("ProductName").Value,
                           ProductUnit = product.Element("Unit").Value,
                           ProductPrice = int.Parse(product.Element("Price").Value)
                       };

        return products.ToList();
    }
    //thực thi phương thức lấy danh sách thực đơn theo id 
    public NttmProducts NttmGetProducts(string productId)
    {
        var doc = XDocument.Load(_filePath);
        var product = (from p in doc.Descendants("Product")
                       where p.Element("ProductId").Value == productId
                       select new NttmProducts
                       {
                           ProductId = p.Element("ProductId").Value,
                           ProductName = p.Element("ProductName").Value,
                           ProductUnit = p.Element("Unit").Value,
                           ProductPrice = int.Parse(p.Element("Price").Value)
                       }).FirstOrDefault();

        return product;
    }
    // thực thi phương thức thêm thực đơn
    public void NttmAddCustomer(NttmProducts product)
    {
        var doc = XDocument.Load(_filePath);
        var newProduct = new XElement("Product",
            new XElement("ProductId", product.ProductId),
            new XElement("ProductName", product.ProductName),
            new XElement("Unit", product.ProductUnit),
            new XElement("Price", product.ProductPrice)
        );
        doc.Root.Add(newProduct);
        doc.Save(_filePath);
    }
    // thực thi phương thức cập nhật
    public void NttmUpdateCustomer(NttmProducts product)
    {
        var doc = XDocument.Load(_filePath);
        // lấy thực đơn theo id 
        var productToUpdate = doc.Descendants("Product")
                                 .FirstOrDefault(p => p.Element("ProductId").Value == product.ProductId);
        // nếu có thì sửa thông tin 
        if (productToUpdate != null)
        {
            productToUpdate.Element("ProductName").Value = product.ProductName;
            productToUpdate.Element("Unit").Value = product.ProductUnit;
            productToUpdate.Element("Price").Value = product.ProductPrice.ToString();
            doc.Save(_filePath);
        }
    }
    // thực thi phương thức tìm kiếm 
    public IList<NttmProducts> NttmSearchCustomer(string name)
    {
        var doc = XDocument.Load(_filePath);
        var products = from product in doc.Descendants("Product")
                       where product.Element("ProductName").Value.Contains(name)
                       select new NttmProducts
                       {
                           ProductId = product.Element("ProductId").Value,
                           ProductName = product.Element("ProductName").Value,
                           ProductUnit = product.Element("Unit").Value,
                           ProductPrice = int.Parse(product.Element("Price").Value)
                       };

        return products.ToList();
    }
    // thực thi phương thức xóa 
    public void NttmDeleteCustomer(NttmProducts product)
    {
        var doc = XDocument.Load(_filePath);
        var productToDelete = doc.Descendants("Product")
                                 .FirstOrDefault(p => p.Element("ProductId").Value == product.ProductId);

        if (productToDelete != null)
        {
            productToDelete.Remove();
            doc.Save(_filePath);
        }
    }
}