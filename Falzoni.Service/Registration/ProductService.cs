﻿using Falzoni.Domain.DTO.Registration;
using Falzoni.Domain.Interfaces.Registration;
using System.Collections.Generic;
using System;
using Falzoni.Domain.Interfaces.Base;
using System.Linq;

namespace Falzoni.Service.Registration
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        //private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, 
            //IProductCategoryRepository productCategoryRepository,
            IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            //_productCategoryRepository = productCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        public ProductDTO Get(Guid Id)
        {
            var product = _productRepository.Get(Id);

            return new ProductDTO(product);
        }

        public List<ProductDTO> GetAll()
        {
            var products = _productRepository.GetAll();

            return products.ToList().ConvertAll(c => new ProductDTO(c));
        }

        public void Add(ProductDTO productDTO)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    productDTO.ConfigureNewEntity();

                    var product = productDTO.ConvertToEntity();

                    _productRepository.Add(product);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void Update(ProductDTO productDTO)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    var product = productDTO.ConvertToEntity();

                    _productRepository.Update(product);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
    }
}
