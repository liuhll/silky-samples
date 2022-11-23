namespace Order.Application.Contracts.Order.Dtos;

public class GetOrderPageInput
{
    /// <summary>
    /// 消费者
    /// </summary>
    public string ConsumeName { get; set; }

    /// <summary>
    /// 业务订单号
    /// </summary>
    public string OrderNo { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// 每页数
    /// </summary>
    public int PageSize { get; set; } = 10;

    /// <summary>
    /// 第几页
    /// </summary>
    public int PageIndex { get; set; } = 1;
}