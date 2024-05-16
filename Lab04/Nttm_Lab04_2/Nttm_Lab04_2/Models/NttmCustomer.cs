using Nttm_Lab04_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nttm_Lab04_2.Models
{
    //định nghĩa lớp NttmCustomer
    public class NttmCustomer
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Balance { get; set; }
    }
    public interface NttmICustomerRepository
    {
        //khai báo phương thức lấy danh sách khách hàng
        IList<NttmCustomer> NttmGetCustomers();
        //khai báo phương thức lấy khách hàng
        NttmCustomer NttmGetCustomers(string customerId);
        //khai báo phương thức thêm khách hàng
        void NttmAddCustomer(NttmCustomer cus);
        //khai báo phương thức cập nhật khách hàng
        void NttmUpdateCustomer(NttmCustomer cus);
        //khai báo phương thức tìm kiếm khách hàng
        IList<NttmCustomer> NttmSearchCustomer(string name);
        //khai báo phương thức xóa khách hàng
        void NttmDeleteCustomer(NttmCustomer cus);
    }
    //định nghĩa lớp CustomerRepository thực thi từ giao diện ICustomerRepository
    
}
public class NttmCustomerRepository : NttmICustomerRepository
{
    //khởi tạo danh sách khách hàng
    static readonly List<NttmCustomer> data = new List<NttmCustomer>()
            {
            new NttmCustomer(){ CustomerId = "KH001",
            FullName = "Nguyễn Thị Trà Mi",Address = "Hà Nội",
            Email = "traminguyen0304@gmail.com",
            Phone = "0963.225.045",Balance = 15200000},
            new NttmCustomer(){ CustomerId = "KH002",
            FullName = "Đỗ Thị Cúc",Address = "Hà Nội",
            Email = "cucdt@gmail.com",Phone = "0986.767.444",
            Balance = 2200000},
            new NttmCustomer(){ CustomerId = "KH003",
            FullName = "Nguyễn Tuấn Thắng",Address = "Nam Định",
            Email = "thangnt@gmail.com",Phone = "0924.656.542",
            Balance = 1200000},
            new NttmCustomer(){ CustomerId = "KH004",
            FullName = "Lê Ngọc Hải",Address = "Hà Nội",
            Email = "hailn@gmail.com",Phone = "0996.555.267",
            Balance = 6200000}
        };
    //thực thi phương thức lấy danh sách khách hàng
    public IList<NttmCustomer> NttmGetCustomers()
    {
        return data;
    }
    //thực thi phương thức tìm khách hàng theo tên
    public IList<NttmCustomer> NttmSearchCustomer(string name)
    {
        return data.Where(c => c.FullName.EndsWith(name)).ToList();
    }
    //thực thi phương thức lấy khách hàng theo Id
    public NttmCustomer NttmGetCustomer(string customerId)
    {
        return data.FirstOrDefault(c => c.CustomerId.Equals(customerId));
    }
    //thực thi phương thức thêm khách hàng
    public void NttmAddCustomer(NttmCustomer cus)
    {
        data.Add(cus);
    }
    //thực thi phương thức cập nhật khách hàng
    public void NttmUpdateCustomer(NttmCustomer cus)
    {
        //lấy khách hàng theo id
        var customer = data.FirstOrDefault(c =>
        c.CustomerId.Equals(cus.CustomerId));
        //nếu có thì sửa thông tin
        if (customer != null)
        {
            customer.FullName = cus.FullName;
            customer.Address = cus.Address;
            customer.Email = cus.Email;
            customer.Phone = cus.Phone;
            customer.Balance = cus.Balance;
        }
    }

    //thực thi phương thức xóa khách hàng
    public void NttmDeleteCustomer(NttmCustomer cus)
    {
        data.Remove(cus);
    }
}