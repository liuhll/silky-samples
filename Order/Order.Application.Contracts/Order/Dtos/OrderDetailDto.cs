namespace Order.Application.Contracts.Order.Dtos;

public class OrderDetailDto
{
    /// <summary>
    /// 商品Id
    /// </summary>
    public long ProductId { get; set; }

    /// <summary>
    /// 订购数量
    /// </summary>
    public int Count { get; set; }
}