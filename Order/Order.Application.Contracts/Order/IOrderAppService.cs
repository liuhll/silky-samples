using Microsoft.AspNetCore.Mvc;
using Order.Application.Contracts.Order.Dtos;
using Silky.Rpc.Routing;

namespace Order.Application.Contracts.Order;

/// <summary>
/// 订单服务
/// </summary>
// [ServiceRoute("v1/api/{appservice=order}")]
public interface IOrderAppService
{
    // /// <summary>
    // /// 创建订单
    // /// </summary>
    // /// <param name="input"></param>
    // /// <returns></returns>
    // Task<OrderDto> Create(OrderDto input);
    //
    // /// <summary>
    // /// 更新
    // /// </summary>
    // /// <param name="input"></param>
    // /// <returns></returns>
    // Task<OrderDto> Update(OrderDto input);

    /// <summary>
    /// 新增/更新接口
    /// </summary>
    /// <remarks>Id为时为新增，Id不为空时为更新</remarks>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    [HttpPut("modify")]
    Task<OrderDto> CreateOrUpdate([FromBody]OrderDto input);
    
    [HttpPost("list")]
    [HttpPut("list")]
    Task<OrderDto[]> CreateOrUpdates(OrderDto[] inputs);


    /// <summary>
    /// 通过表单传值
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost("form")]
    [HttpPut("form")]
    Task<OrderDto> CreateOrUpdateForForm([FromForm]OrderDto input);
    
    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<OrderDto> Delete(long id);

    /// <summary>
    /// 通过Id获取订单
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id:long}")]
    Task<OrderDto> GetById(long id);

    // // /// <summary>
    // // /// 获取业务单号订单
    // // /// </summary>
    // // /// <param name="orderNo"></param>
    // // /// <returns></returns>
    [HttpGet("{orderNo}")]
    Task<OrderDto> GetByNo(string orderNo);
    
    [HttpGet("")]
    Task<OrderDto> GetByNoFromHeader([FromHeader]string orderNo);

    /// <summary>
    /// 分页查询
    /// </summary>
    /// <param name="consumeName">消费者</param>
    /// <param name="orderNo">业务单号</param>
    /// <param name="address">地址</param>
    /// <param name="pageSize">每页数</param>
    /// <param name="pageIndex">第几页</param>
    /// <returns></returns>
    // Task<PagedList<OrderDto>> GetPage([FromQuery]string consumeName,
    //     [FromQuery]string orderNo,
    //     [FromQuery]string address,
    //     [FromQuery]int pageSize = 10,
    //     [FromQuery]int pageIndex = 1);

    /// <summary>
    /// 分页查询(new)
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpGet("search")]
    Task<PagedList<OrderDto>> GetPage(GetOrderPageInput input);

    Task<OrderDto> Normal1(string orderNo);
    
    Task<OrderDto> Normal2(OrderDto input);
    
    [HttpPost]
    Task<OrderDto> Normal3([FromBody]string orderNo);
    
    [HttpGet]
    Task<OrderDto> Normal4(OrderDto input);
}