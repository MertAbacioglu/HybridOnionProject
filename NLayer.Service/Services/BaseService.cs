using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.ResultModels;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Core.Wrappers;
using System.Linq.Expressions;

namespace NLayer.Service.Services
{
    public class BaseService<T1, T2> : IService<T1, T2> where T1 : BaseEntity where T2 : IBaseDto

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

        public async Task<Response<bool>> AnyAsync(Expression<Func<T1, bool>> expression, bool tracking = true)
        {
            bool isExist = await _genericRepository.AnyAsync(expression);
            return Response<bool>.Success(StatusCodes.Status204NoContent, isExist);
        }
        public async  Task<Response<T2>> FindAsync(bool tracking=true,params object[] values)
        {
            T1 result = await _genericRepository.FindAsync(tracking,values);

            //if (result == null)
            //    throw new NotFoundExcepiton($"{typeof(T1).Name}{(values)} not found");
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
        public async Task<Response<NoContent>> RemoveAsync(T2 dto)
        {
            T2 removedDto = (await FindAsync(false, dto.ID)).Data;
            T1 toBeDeleted = _mapper.Map<T1>(removedDto);
            //toBeDeleted.Status=DataStatus.Deleted;
            _genericRepository.Remove(toBeDeleted);
            await _unitOfWork.CommitAsync();
            return Response<NoContent>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<Response<T2>> FirstOrDefault(Expression<Func<T1, bool>> exp, bool tracking = true)
        {
            T1 result = await _genericRepository.FirstOrDefault(exp, tracking);
            T2 dto = _mapper.Map<T2>(result);
            return Response<T2>.Success(StatusCodes.Status200OK, dto);
        }

        public async Task<Response<IEnumerable<T2>>> GetActives(bool tracking = true)
        {
            IEnumerable<T1> result = await _genericRepository.GetActivesAsIQueryable(tracking).ToListAsync();
            IEnumerable<T2> dtos = _mapper.Map<IEnumerable<T2>>(result);
            return Response<IEnumerable<T2>>.Success(StatusCodes.Status200OK, dtos);
        }

        public async Task<Response<IEnumerable<T2>>> GetAll(bool tracking = true)
        {
            IEnumerable<T1> result = await _genericRepository.GetAllAsIQueryable(tracking).ToListAsync();
            IEnumerable<T2> dtos = _mapper.Map<IEnumerable<T2>>(result);
            return Response<IEnumerable<T2>>.Success(StatusCodes.Status200OK, dtos);
        }

        public async Task<Response<IEnumerable<T2>>> GetModifieds(bool tracking = true)
        {
            IEnumerable<T1> result = await _genericRepository.GetModifiedsAsIQueryable(tracking).ToListAsync();
            IEnumerable<T2> dtos = _mapper.Map<IEnumerable<T2>>(result);
            return Response<IEnumerable<T2>>.Success(StatusCodes.Status200OK, dtos);
        }

        public async Task<Response<IEnumerable<T2>>> GetPassives(bool tracking = true)
        {
            IEnumerable<T1> result = await _genericRepository.GetPassivesAsIQueryable(tracking).ToListAsync();
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

        public async Task<Response<object>> Select(Expression<Func<T1, object>> exp, bool tracking = true)
        {
            var result = await _genericRepository.Select(exp, tracking);
            return Response<object>.Success(StatusCodes.Status200OK, result);
        }


        public async Task<Response<NoContent>> UpdateAsync(T2 dto)
        {
            
            T1 toBeUpdated = _mapper.Map<T1>(dto);
            _genericRepository.Update(toBeUpdated);
            await _unitOfWork.CommitAsync();
            return Response<NoContent>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<Response<IEnumerable<T2>>> Where(Expression<Func<T1, bool>> expression, bool tracking = true)
        {
            IEnumerable<T1> result = await _genericRepository.Where(expression, tracking).ToListAsync();
            IEnumerable<T2> dtos = _mapper.Map<IEnumerable<T2>>(result);
            return Response<IEnumerable<T2>>.Success(StatusCodes.Status200OK, dtos);
        }
    }
}