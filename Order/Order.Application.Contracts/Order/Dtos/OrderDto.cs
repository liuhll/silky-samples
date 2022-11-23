namespace Order.Application.Contracts.Order.Dtos;

public class OrderDto
{
    /// <summary>
    /// 订单Id
    /// </summary>
    public long? Id { get; set; }

    /// <summary>
    /// 业务订单号
    /// </summary>
    public string OrderNo { get; set; }

    /// <summary>
    /// 消费者名称
    /// </summary>
    public string ConsumeName { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    public string Address { get; set; }

    // /// <summary>
    // /// 商品明细
    // /// </summary>
    // public OrderDetailDto[] Products { get; set; }
}