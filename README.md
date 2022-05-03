# Clothing Size API Client

#### By Zoe Weinstein, Amy Young, Chris Nakayama, Wajma Niazi, Jonathan Delcid 


## Technologies Used

* VS Code
* C# 
* .NET 5.0
* ASP.NET Core MVC
* Bootstrap
* CSS

## Description
* Shows various endpoints for the Clothing Size API: `https://github.com/MxZoe/ClothingSizeApi.Solution/tree/main/ClothingSizeApi`

## Setup/Installation Requirements
 
* Go to GitHub: `https://github.com/MxZoe/ClothingSizeApi.Solution/tree/main/ClothingSizeApi`
* Clone Repository to your desktop
* also clone `https://github.com/MxZoe/ClothingSizeApi.Solution/tree/main/ClothingSizeApi` and follow instructions in that readme to update the database and run the server simultaneously


## API Endpoints
*GET /api/Brands 
*GET /api/Brands?{key}={value}
**Brand key query options: brandid, clothingtype, gender, xxxs, xxs, xs, s, m, l, xl, xxl, xxxl, xxxxl
*Get /api/Brands/{id}
*POST /api/Brands 
*PUT /api/Brands/{id} 
*Delete /api/Brands/{id} 

*GET /api/Sizes 
*GET /api/Sizes?{key}={value}
**Size key query options: sizeid, clothingtype, gender, lettersize, neck, chest, sleeve, waist, hip inseam
*Get /api/Sizes/{id}
*POST /api/Sizes
*PUT /api/Sizes/{id} 
*Delete /api/Sizes/{id}