global using NUnit.Framework;
global using BooksAPI.DTOs.BookDtos;
global using BooksAPI.DTOs.CategoryDtos;
global using DataAccessLayer.Entities;
global using DataAccessLayer.Interfaces;
global using DataAccessLayer.Repositories;
global using DataAccessLayer;
global using Microsoft.EntityFrameworkCore;
global using BusinessLogicLayer.Interfaces;
global using BusinessLogicLayer.Service;
global using BusinessLogicLayer.Exceptions;
global using BusinessLogicLayer.Helpers;
global using AutoMapper;
global using Microsoft.Extensions.Caching.Distributed;
global using Moq;