using System;

namespace EShop.Shared.Dtos.ResponseDtos;

//Bu Sınıf içinde;
//1- Geri döndürülecek datayı
//2- Geri döndürülecek hata mesajını
//3- Geri döndürülecek hata kodunu
//4- Geri döndürülecek başarılı olup olmadığını
// tutacağız.

public class ResponseDto<T>
{
    public T? Data { get; set; }
    public string? ErrorMessage { get; set; }
    public int StatusCode { get; set; }
    public bool IsSuccess { get; set; }



    // Başarılı durumlarda kullanılacak metot
    public static ResponseDto<T> Success(T? data, int statusCode)
    {
        return new ResponseDto<T>
        {
            Data = data,
            StatusCode = statusCode,
            IsSuccess = true
        };
    }

    //Başarılı ama geriye data döndürülmeyecek durumlarda kullanılacak metot
    public static ResponseDto<T> Success(int statusCode)
    {
        return new ResponseDto<T>
        {
            Data = default,
            StatusCode = statusCode,
            IsSuccess = true
        };
    }

    //Hata durumlarında kullanılacak metot
    public static ResponseDto<T> Fail(int statusCode, string errorMessage)
    {
        return new ResponseDto<T>
        {
            ErrorMessage = errorMessage,
            StatusCode = statusCode,
            IsSuccess = false
        };
    }
}
