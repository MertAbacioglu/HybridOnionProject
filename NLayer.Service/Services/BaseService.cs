using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.DTOs;
using NLayer.Core.Enums;
using NLayer.Core.ModelInterfaces;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.ResultModels;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Core.Wrappers;
using NLayer.Service.Exceptions;
using System.Linq.Expressions;

namespace NLayer.Service.Services
{
    public class BaseService<T1, T2> : IService<T1, T2> where T1 : BaseEntity where T2 : BaseDto

    {
        protected readonly IGenericRepository<T1> _genericRepository;
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;

        public BaseService(IGenericRepository<T1> genericRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response<bool>> AnyAsync(Expression<Func<T1, bool>> expression)
        {
            bool isExist = await _genericRepository.AnyAsync(expression);
            return Response<bool>.Success(StatusCodes.Status204NoContent, isExist);
        }
        public async Task<Response<T2>> FindAsync(params object[] values)
        {
            T1 result = await _genericRepository.FindAsync(values);

            if (result == null)
                throw new NotFoundExcepiton($"{typeof(T1).Name}{(values)} not found");
            T2 dto = _mapper.Map<T2>(result);
            return Response<T2>.Success(StatusCodes.Status200OK, dto);
        }

        public async Task<Response<NoContent>> AddAsync(T2 dto)
        {
            T1 toBeAdded = _mapper.Map<T1>(dto);
            await _genericRepository.AddAsync(toBeAdded);
            await _unitOfWork.CommitAsync();
            return Response<NoContent>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<Response<NoContent>> AddRangeAsync(IEnumerable<T2> dtos)
        {
            IEnumerable<T1> toBeAddeds = _mapper.Map<IEnumerable<T1>>(dtos);
            await _genericRepository.AddRangeAsync(toBeAddeds);
            await _unitOfWork.CommitAsync();
            return Response<NoContent>.Success(StatusCodes.Status204NoContent);
        }


        public async Task<Response<NoContent>> DestroyAsync(T2 dto)
        {
            T1 toBeDestroyed = _mapper.Map<T1>(dto);
            _genericRepository.Remove(toBeDestroyed);
            await _unitOfWork.CommitAsync();
            return Response<NoContent>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<Response<NoContent>> DestroyRangeAsync(IEnumerable<T2> dtos)
        {
            IEnumerable<T1> toBeDestroyeds = _mapper.Map<IEnumerable<T1>>(dtos);
            _genericRepository.DestroyRange(toBeDestroyeds);
            await _unitOfWork.CommitAsync();
            return Response<NoContent>.Success(StatusCodes.Status204NoContent);
        }
        public async Task<Response<NoContent>> RemoveAsync(int id)
        {
            T2 dto = (await FindAsync(id)).Data;
            T1 toBeDeleted = _mapper.Map<T1>(dto);
            //toBeDeleted.Status=DataStatus.Deleted;
            _genericRepository.Remove(toBeDeleted);
            await _unitOfWork.CommitAsync();
            return Response<NoContent>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<Response<T2>> FirstOrDefault(Expression<Func<T1, bool>> exp)
        {
            T1 result = await _genericRepository.FirstOrDefault(exp);
            T2 dto = _mapper.Map<T2>(result);
            return Response<T2>.Success(StatusCodes.Status200OK, dto);
        }

        public async Task<Response<IEnumerable<T2>>> GetActives()
        {
            IEnumerable<T1> result = await _genericRepository.GetActivesAsIQueryable().ToListAsync();
            IEnumerable<T2> dtos = _mapper.Map<IEnumerable<T2>>(result);
            return Response<IEnumerable<T2>>.Success(StatusCodes.Status200OK, dtos);
        }

        public async Task<Response<IEnumerable<T2>>> GetAll()
        {
            IEnumerable<T1> result = await _genericRepository.GetAllAsIQueryable().ToListAsync();
            IEnumerable<T2> dtos = _mapper.Map<IEnumerable<T2>>(result);
            return Response<IEnumerable<T2>>.Success(StatusCodes.Status200OK, dtos);
        }

        public async Task<Response<IEnumerable<T2>>> GetModifieds()
        {
            IEnumerable<T1> result = await _genericRepository.GetModifiedsAsIQueryable().ToListAsync();
            IEnumerable<T2> dtos = _mapper.Map<IEnumerable<T2>>(result);
            return Response<IEnumerable<T2>>.Success(StatusCodes.Status200OK, dtos);
        }

        public async Task<Response<IEnumerable<T2>>> GetPassives()
        {
            IEnumerable<T1> result = await _genericRepository.GetPassivesAsIQueryable().ToListAsync();
            IEnumerable<T2> dtos = _mapper.Map<IEnumerable<T2>>(result);
            return Response<IEnumerable<T2>>.Success(StatusCodes.Status200OK, dtos);
        }

        public async Task<Response<NoContent>> RemoveRangeAsync(IEnumerable<T2> dtos)
        {
            IEnumerable<T1> toBeDeleteds = _mapper.Map<IEnumerable<T1>>(dtos);
            _genericRepository.RemoveRange(toBeDeleteds);
            await _unitOfWork.CommitAsync();
            return Response<NoContent>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<Response<object>> Select(Expression<Func<T1, object>> exp)
        {
            var result = await _genericRepository.Select(exp);
            return Response<object>.Success(StatusCodes.Status200OK, result);
        }

        public async Task<Response<IEnumerable<X>>> SelectViaClass<X>(Expression<Func<T1, X>> exp)
        {
            IEnumerable<X> result = await _genericRepository.SelectViaClass(exp).ToListAsync();
            return Response<IEnumerable<X>>.Success(StatusCodes.Status200OK, result);
        }

        public async Task<Response<NoContent>> UpdateAsync(T2 dto)
        {
            T1 toBeUpdated = _mapper.Map<T1>(dto);
            _genericRepository.Update(toBeUpdated);
            await _unitOfWork.CommitAsync();
            return Response<NoContent>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<Response<IEnumerable<T2>>> Where(Expression<Func<T1, bool>> expression)
        {
            IEnumerable<T1> result = await _genericRepository.Where(expression).ToListAsync();
            IEnumerable<T2> dtos = _mapper.Map<IEnumerable<T2>>(result);
            return Response<IEnumerable<T2>>.Success(StatusCodes.Status200OK, dtos);
        }
    }
}