using Order.Application.Contracts.Order;
using Order.Application.Contracts.Order.Dtos;

namespace Order.Application.Order;

public class OrderAppService : IOrderAppService
{
    public Task<OrderDto> Create(OrderDto input)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> Update(OrderDto input)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> CreateOrUpdate(OrderDto input)
    {
        if (input.Id.HasValue)
        {
            // 更新
        }
        else
        {
            // 新增
        }

        throw new NotImplementedException();
    }

    public Task<OrderDto[]> CreateOrUpdates(OrderDto[] inputs)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> CreateOrUpdateForForm(OrderDto input)
    {
        throw new NotImplementedException();
    }
    

    public Task<OrderDto> Delete(long id)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> GetByNo(string orderNo)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> GetByNoFromHeader(string orderNo)
    {
        throw new NotImplementedException();
    }

    public Task<PagedList<OrderDto>> GetPage(GetOrderPageInput input)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> Normal1(string orderNo)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> Normal2(OrderDto input)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> Normal3(string orderNo)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> Normal4(OrderDto input)
    {
        throw new NotImplementedException();
    }


    public Task<PagedList<OrderDto>> GetPage(string consumeName, string orderNo, string address, int pageSize = 10, int pageIndex = 1)
    {
        throw new NotImplementedException();
    }
}