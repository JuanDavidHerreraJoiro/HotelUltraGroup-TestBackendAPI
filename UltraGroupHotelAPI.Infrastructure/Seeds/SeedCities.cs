﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraGroupHotelAPI.Application.Features.Genders.Queries.GetGendersList;
using UltraGroupHotelAPI.Domain.Classes;
using UltraGroupHotelAPI.Infrastructure.Persistence;

namespace UltraGroupHotelAPI.Infrastructure.Seeds
{
    public class SeedCities
    {
        public static async Task SeedAsync(UltraGroupHotelDbContext context, ILogger<SeedCities> logger)
        {
            try
            {
                if (!context.Cities.Any())
                {
                    context.Cities.AddRange(GetPreconfiguredGender());
                    await context.SaveChangesAsync();
                    logger.LogInformation("Data seed new for tha table cities of database {context}", typeof(UltraGroupHotelDbContext).Name);
                }
            }
            catch (SqlException)
            {

                throw;
            }
        }

        private static IEnumerable<City> GetPreconfiguredGender()
        {
            List<DepartmentsMunicipalities> listDepartmentsMunicipalities = JsonConvert.DeserializeObject<List<DepartmentsMunicipalities>>(JsonCities());

            var listMunicipality = listDepartmentsMunicipalities.Select(m => m.Municipio).ToList();

            List<City> cityList = listMunicipality.Select((municipio) => new City { CityName = municipio }).ToList();

            return cityList;
        }


        private static string JsonCities()
        {
           string json = @"[{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.001','municipio':'Medellín'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.002','municipio':'Abejorral'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.004','municipio':'Abriaquí'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.021','municipio':'Alejandría'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.03','municipio':'Amagá'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.031','municipio':'Amalfi'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.034','municipio':'Andes'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.036','municipio':'Angelópolis'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.038','municipio':'Angostura'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.04','municipio':'Anorí'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.832','municipio':'Tununguá'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.044','municipio':'Anza'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.045','municipio':'Apartadó'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.051','municipio':'Arboletes'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.055','municipio':'Argelia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.059','municipio':'Armenia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.079','municipio':'Barbosa'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.088','municipio':'Bello'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.091','municipio':'Betania'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.093','municipio':'Betulia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.101','municipio':'Ciudad Bolívar'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.107','municipio':'Briceño'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.113','municipio':'Buriticá'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.12','municipio':'Cáceres'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.125','municipio':'Caicedo'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.129','municipio':'Caldas'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.134','municipio':'Campamento'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.138','municipio':'Cañasgordas'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.142','municipio':'Caracolí'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.145','municipio':'Caramanta'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.147','municipio':'Carepa'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.476','municipio':'Motavita'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.15','municipio':'Carolina'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.154','municipio':'Caucasia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.172','municipio':'Chigorodó'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.19','municipio':'Cisneros'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.197','municipio':'Cocorná'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.206','municipio':'Concepción'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.209','municipio':'Concordia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.212','municipio':'Copacabana'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.234','municipio':'Dabeiba'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.237','municipio':'Don Matías'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.24','municipio':'Ebéjico'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.25','municipio':'El Bagre'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.264','municipio':'Entrerrios'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.266','municipio':'Envigado'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.282','municipio':'Fredonia'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.675','municipio':'San Bernardo del Viento'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.306','municipio':'Giraldo'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.308','municipio':'Girardota'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.31','municipio':'Gómez Plata'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.361','municipio':'Istmina'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.315','municipio':'Guadalupe'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.318','municipio':'Guarne'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.321','municipio':'Guatapé'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.347','municipio':'Heliconia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.353','municipio':'Hispania'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.36','municipio':'Itagui'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.361','municipio':'Ituango'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.086','municipio':'Belmira'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.368','municipio':'Jericó'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.376','municipio':'La Ceja'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.38','municipio':'La Estrella'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.39','municipio':'La Pintada'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.4','municipio':'La Unión'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.411','municipio':'Liborina'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.425','municipio':'Maceo'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.44','municipio':'Marinilla'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.467','municipio':'Montebello'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.475','municipio':'Murindó'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.48','municipio':'Mutatá'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.483','municipio':'Nariño'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.49','municipio':'Necoclí'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.495','municipio':'Nechí'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.501','municipio':'Olaya'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.541','municipio':'Peñol'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.543','municipio':'Peque'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.576','municipio':'Pueblorrico'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.579','municipio':'Puerto Berrío'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.585','municipio':'Puerto Nare'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.591','municipio':'Puerto Triunfo'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.604','municipio':'Remedios'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.607','municipio':'Retiro'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.615','municipio':'Rionegro'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.628','municipio':'Sabanalarga'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.631','municipio':'Sabaneta'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.642','municipio':'Salgar'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.189','municipio':'Ciénega'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.699','municipio':'Santacruz'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.652','municipio':'San Francisco'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.656','municipio':'San Jerónimo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.575','municipio':'Puerto Wilches'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.573','municipio':'Puerto Parra'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.66','municipio':'San Luis'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.664','municipio':'San Pedro'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.667','municipio':'San Rafael'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.67','municipio':'San Roque'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.674','municipio':'San Vicente'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.679','municipio':'Santa Bárbara'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.69','municipio':'Santo Domingo'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.697','municipio':'El Santuario'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.736','municipio':'Segovia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.761','municipio':'Sopetrán'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.37','municipio':'Uribe'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.789','municipio':'Támesis'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.79','municipio':'Tarazá'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.792','municipio':'Tarso'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.809','municipio':'Titiribí'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.819','municipio':'Toledo'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.837','municipio':'Turbo'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.842','municipio':'Uramita'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.847','municipio':'Urrao'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.854','municipio':'Valdivia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.856','municipio':'Valparaíso'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.858','municipio':'Vegachí'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.861','municipio':'Venecia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.885','municipio':'Yalí'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.887','municipio':'Yarumal'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.89','municipio':'Yolombó'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.893','municipio':'Yondó'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.895','municipio':'Zaragoza'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.001','municipio':'Barranquilla'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.078','municipio':'Baranoa'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.141','municipio':'Candelaria'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.296','municipio':'Galapa'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.421','municipio':'Luruaco'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.433','municipio':'Malambo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.436','municipio':'Manatí'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.549','municipio':'Piojó'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.558','municipio':'Polonuevo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.634','municipio':'Sabanagrande'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.638','municipio':'Sabanalarga'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.675','municipio':'Santa Lucía'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.685','municipio':'Santo Tomás'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.758','municipio':'Soledad'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.77','municipio':'Suan'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.832','municipio':'Tubará'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.849','municipio':'Usiacurí'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.006','municipio':'Achí'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.042','municipio':'Arenal'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.052','municipio':'Arjona'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.062','municipio':'Arroyohondo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.14','municipio':'Calamar'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.16','municipio':'Cantagallo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.188','municipio':'Cicuco'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.212','municipio':'Córdoba'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.222','municipio':'Clemencia'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.248','municipio':'El Guamo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.43','municipio':'Magangué'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.433','municipio':'Mahates'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.44','municipio':'Margarita'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.458','municipio':'Montecristo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.468','municipio':'Mompós'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.473','municipio':'Morales'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.49','municipio':'Norosí'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.549','municipio':'Pinillos'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.58','municipio':'Regidor'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.6','municipio':'Río Viejo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.647','municipio':'San Estanislao'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.65','municipio':'San Fernando'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.657','municipio':'San Juan Nepomuceno'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.673','municipio':'Santa Catalina'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.683','municipio':'Santa Rosa'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.744','municipio':'Simití'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.76','municipio':'Soplaviento'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.78','municipio':'Talaigua Nuevo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.81','municipio':'Tiquisio'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.836','municipio':'Turbaco'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.838','municipio':'Turbaná'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.873','municipio':'Villanueva'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.001','municipio':'Tunja'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.022','municipio':'Almeida'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.047','municipio':'Aquitania'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.051','municipio':'Arcabuco'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.09','municipio':'Berbeo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.092','municipio':'Betéitiva'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.097','municipio':'Boavita'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.104','municipio':'Boyacá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.106','municipio':'Briceño'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.109','municipio':'Buena Vista'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.114','municipio':'Busbanzá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.131','municipio':'Caldas'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.135','municipio':'Campohermoso'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.162','municipio':'Cerinza'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.172','municipio':'Chinavita'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.176','municipio':'Chiquinquirá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.18','municipio':'Chiscas'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.183','municipio':'Chita'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.185','municipio':'Chitaraque'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.187','municipio':'Chivatá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.204','municipio':'Cómbita'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.212','municipio':'Coper'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.215','municipio':'Corrales'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.218','municipio':'Covarachía'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.223','municipio':'Cubará'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.224','municipio':'Cucaita'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.226','municipio':'Cuítiva'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.232','municipio':'Chíquiza'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.236','municipio':'Chivor'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.238','municipio':'Duitama'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.244','municipio':'El Cocuy'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.248','municipio':'El Espino'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.272','municipio':'Firavitoba'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.276','municipio':'Floresta'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.293','municipio':'Gachantivá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.296','municipio':'Gameza'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.299','municipio':'Garagoa'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.317','municipio':'Guacamayas'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.322','municipio':'Guateque'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.325','municipio':'Guayatá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.332','municipio':'Güicán'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.362','municipio':'Iza'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.367','municipio':'Jenesano'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.368','municipio':'Jericó'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.377','municipio':'Labranzagrande'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.38','municipio':'La Capilla'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.401','municipio':'La Victoria'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.425','municipio':'Macanal'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.442','municipio':'Maripí'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.455','municipio':'Miraflores'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.464','municipio':'Mongua'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.466','municipio':'Monguí'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.469','municipio':'Moniquirá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.48','municipio':'Muzo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.491','municipio':'Nobsa'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.494','municipio':'Nuevo Colón'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.5','municipio':'Oicatá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.507','municipio':'Otanche'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.511','municipio':'Pachavita'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.514','municipio':'Páez'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.516','municipio':'Paipa'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.518','municipio':'Pajarito'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.522','municipio':'Panqueba'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.531','municipio':'Pauna'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.533','municipio':'Paya'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.542','municipio':'Pesca'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.55','municipio':'Pisba'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.572','municipio':'Puerto Boyacá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.58','municipio':'Quípama'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.599','municipio':'Ramiriquí'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.6','municipio':'Ráquira'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.621','municipio':'Rondón'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.632','municipio':'Saboyá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.638','municipio':'Sáchica'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.646','municipio':'Samacá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.66','municipio':'San Eduardo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.673','municipio':'San Mateo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.686','municipio':'Santana'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.69','municipio':'Santa María'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.696','municipio':'Santa Sofía'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.72','municipio':'Sativanorte'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.723','municipio':'Sativasur'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.74','municipio':'Siachoque'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.753','municipio':'Soatá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.755','municipio':'Socotá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.757','municipio':'Socha'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.759','municipio':'Sogamoso'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.761','municipio':'Somondoco'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.762','municipio':'Sora'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.763','municipio':'Sotaquirá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.764','municipio':'Soracá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.774','municipio':'Susacón'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.776','municipio':'Sutamarchán'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.778','municipio':'Sutatenza'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.79','municipio':'Tasco'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.798','municipio':'Tenza'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.804','municipio':'Tibaná'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.808','municipio':'Tinjacá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.81','municipio':'Tipacoque'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.814','municipio':'Toca'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.82','municipio':'Tópaga'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.822','municipio':'Tota'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.835','municipio':'Turmequé'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.839','municipio':'Tutazá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.842','municipio':'Umbita'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.861','municipio':'Ventaquemada'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.879','municipio':'Viracachá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.897','municipio':'Zetaquira'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.001','municipio':'Manizales'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.013','municipio':'Aguadas'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.042','municipio':'Anserma'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.05','municipio':'Aranzazu'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.088','municipio':'Belalcázar'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.174','municipio':'Chinchiná'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.272','municipio':'Filadelfia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.38','municipio':'La Dorada'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.388','municipio':'La Merced'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.433','municipio':'Manzanares'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.442','municipio':'Marmato'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.446','municipio':'Marulanda'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.486','municipio':'Neira'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.495','municipio':'Norcasia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.513','municipio':'Pácora'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.524','municipio':'Palestina'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.541','municipio':'Pensilvania'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.614','municipio':'Riosucio'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.616','municipio':'Risaralda'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.653','municipio':'Salamina'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.662','municipio':'Samaná'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.665','municipio':'San José'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.777','municipio':'Supía'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.867','municipio':'Victoria'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.873','municipio':'Villamaría'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'17','departamento':'Caldas','c_digo_dane_del_municipio':'17.877','municipio':'Viterbo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'18','departamento':'Caquetá','c_digo_dane_del_municipio':'18.001','municipio':'Florencia'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'18','departamento':'Caquetá','c_digo_dane_del_municipio':'18.029','municipio':'Albania'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'18','departamento':'Caquetá','c_digo_dane_del_municipio':'18.205','municipio':'Curillo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'18','departamento':'Caquetá','c_digo_dane_del_municipio':'18.247','municipio':'El Doncello'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'18','departamento':'Caquetá','c_digo_dane_del_municipio':'18.256','municipio':'El Paujil'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'18','departamento':'Caquetá','c_digo_dane_del_municipio':'18.479','municipio':'Morelia'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'18','departamento':'Caquetá','c_digo_dane_del_municipio':'18.592','municipio':'Puerto Rico'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'18','departamento':'Caquetá','c_digo_dane_del_municipio':'18.756','municipio':'Solano'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'18','departamento':'Caquetá','c_digo_dane_del_municipio':'18.785','municipio':'Solita'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'18','departamento':'Caquetá','c_digo_dane_del_municipio':'18.86','municipio':'Valparaíso'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.001','municipio':'Popayán'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.022','municipio':'Almaguer'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.05','municipio':'Argelia'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.075','municipio':'Balboa'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.1','municipio':'Bolívar'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.11','municipio':'Buenos Aires'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.13','municipio':'Cajibío'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.137','municipio':'Caldono'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.142','municipio':'Caloto'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.212','municipio':'Corinto'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.256','municipio':'El Tambo'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.29','municipio':'Florencia'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.3','municipio':'Guachené'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.318','municipio':'Guapi'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.355','municipio':'Inzá'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.364','municipio':'Jambaló'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.392','municipio':'La Sierra'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.397','municipio':'La Vega'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.418','municipio':'López'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.45','municipio':'Mercaderes'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.455','municipio':'Miranda'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.473','municipio':'Morales'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.513','municipio':'Padilla'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.532','municipio':'Patía'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.533','municipio':'Piamonte'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.548','municipio':'Piendamó'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.573','municipio':'Puerto Tejada'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.585','municipio':'Puracé'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.622','municipio':'Rosas'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.701','municipio':'Santa Rosa'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.743','municipio':'Silvia'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.76','municipio':'Sotara'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.78','municipio':'Suárez'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.785','municipio':'Sucre'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.807','municipio':'Timbío'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.809','municipio':'Timbiquí'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.821','municipio':'Toribio'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.824','municipio':'Totoró'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.845','municipio':'Villa Rica'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.001','municipio':'Valledupar'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.011','municipio':'Aguachica'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.013','municipio':'Agustín Codazzi'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.032','municipio':'Astrea'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.045','municipio':'Becerril'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.06','municipio':'Bosconia'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.175','municipio':'Chimichagua'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.178','municipio':'Chiriguaná'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.228','municipio':'Curumaní'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.238','municipio':'El Copey'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.25','municipio':'El Paso'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.295','municipio':'Gamarra'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.31','municipio':'González'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.383','municipio':'La Gloria'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.443','municipio':'Manaure'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.517','municipio':'Pailitas'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.55','municipio':'Pelaya'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.57','municipio':'Pueblo Bello'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.621','municipio':'La Paz'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.71','municipio':'San Alberto'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.75','municipio':'San Diego'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.77','municipio':'San Martín'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.787','municipio':'Tamalameque'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.001','municipio':'Montería'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.068','municipio':'Ayapel'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.079','municipio':'Buenavista'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.09','municipio':'Canalete'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.162','municipio':'Cereté'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.168','municipio':'Chimá'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.182','municipio':'Chinú'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.3','municipio':'Cotorra'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.417','municipio':'Lorica'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.419','municipio':'Los Córdobas'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.464','municipio':'Momil'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.5','municipio':'Moñitos'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.555','municipio':'Planeta Rica'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.57','municipio':'Pueblo Nuevo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.574','municipio':'Puerto Escondido'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.586','municipio':'Purísima'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.66','municipio':'Sahagún'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.67','municipio':'San Andrés Sotavento'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.672','municipio':'San Antero'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.686','municipio':'San Pelayo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.807','municipio':'Tierralta'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.815','municipio':'Tuchín'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.855','municipio':'Valencia'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.035','municipio':'Anapoima'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.053','municipio':'Arbeláez'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.086','municipio':'Beltrán'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.095','municipio':'Bituima'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.099','municipio':'Bojacá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.12','municipio':'Cabrera'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.123','municipio':'Cachipay'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.126','municipio':'Cajicá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.148','municipio':'Caparrapí'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.151','municipio':'Caqueza'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.168','municipio':'Chaguaní'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.178','municipio':'Chipaque'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.181','municipio':'Choachí'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.183','municipio':'Chocontá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.2','municipio':'Cogua'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.214','municipio':'Cota'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.224','municipio':'Cucunubá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.245','municipio':'El Colegio'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.26','municipio':'El Rosal'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.279','municipio':'Fomeque'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.281','municipio':'Fosca'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.286','municipio':'Funza'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.288','municipio':'Fúquene'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.293','municipio':'Gachala'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.295','municipio':'Gachancipá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.297','municipio':'Gachetá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.307','municipio':'Girardot'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.312','municipio':'Granada'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.317','municipio':'Guachetá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.32','municipio':'Guaduas'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.322','municipio':'Guasca'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.324','municipio':'Guataquí'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.326','municipio':'Guatavita'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.335','municipio':'Guayabetal'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.339','municipio':'Gutiérrez'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.368','municipio':'Jerusalén'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.372','municipio':'Junín'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.377','municipio':'La Calera'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.386','municipio':'La Mesa'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.394','municipio':'La Palma'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.398','municipio':'La Peña'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.402','municipio':'La Vega'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.407','municipio':'Lenguazaque'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.426','municipio':'Macheta'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.43','municipio':'Madrid'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.436','municipio':'Manta'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.438','municipio':'Medina'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.473','municipio':'Mosquera'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.483','municipio':'Nariño'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.486','municipio':'Nemocón'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.488','municipio':'Nilo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.489','municipio':'Nimaima'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.491','municipio':'Nocaima'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.506','municipio':'Venecia'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.513','municipio':'Pacho'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.518','municipio':'Paime'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.524','municipio':'Pandi'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.53','municipio':'Paratebueno'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.535','municipio':'Pasca'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.572','municipio':'Puerto Salgar'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.58','municipio':'Pulí'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.592','municipio':'Quebradanegra'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.594','municipio':'Quetame'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.596','municipio':'Quipile'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.599','municipio':'Apulo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.612','municipio':'Ricaurte'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.649','municipio':'San Bernardo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.653','municipio':'San Cayetano'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.658','municipio':'San Francisco'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.736','municipio':'Sesquilé'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.74','municipio':'Sibaté'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.743','municipio':'Silvania'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.745','municipio':'Simijaca'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.754','municipio':'Soacha'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.769','municipio':'Subachoque'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.772','municipio':'Suesca'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.777','municipio':'Supatá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.779','municipio':'Susa'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.781','municipio':'Sutatausa'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.785','municipio':'Tabio'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.793','municipio':'Tausa'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.797','municipio':'Tena'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.799','municipio':'Tenjo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.805','municipio':'Tibacuy'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.807','municipio':'Tibirita'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.815','municipio':'Tocaima'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.817','municipio':'Tocancipá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.823','municipio':'Topaipí'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.839','municipio':'Ubalá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.841','municipio':'Ubaque'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.845','municipio':'Une'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.851','municipio':'Útica'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.867','municipio':'Vianí'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.871','municipio':'Villagómez'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.873','municipio':'Villapinzón'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.875','municipio':'Villeta'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.878','municipio':'Viotá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.898','municipio':'Zipacón'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.001','municipio':'Quibdó'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.006','municipio':'Acandí'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.025','municipio':'Alto Baudo'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.05','municipio':'Atrato'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.073','municipio':'Bagadó'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.075','municipio':'Bahía Solano'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.077','municipio':'Bajo Baudó'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.099','municipio':'Bojaya'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.16','municipio':'Cértegui'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.205','municipio':'Condoto'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.372','municipio':'Juradó'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.413','municipio':'Lloró'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.425','municipio':'Medio Atrato'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.43','municipio':'Medio Baudó'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.45','municipio':'Medio San Juan'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.491','municipio':'Nóvita'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.495','municipio':'Nuquí'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.58','municipio':'Río Iro'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.6','municipio':'Río Quito'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.615','municipio':'Riosucio'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.745','municipio':'Sipí'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.8','municipio':'Unguía'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.001','municipio':'Neiva'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.006','municipio':'Acevedo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.013','municipio':'Agrado'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.016','municipio':'Aipe'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.02','municipio':'Algeciras'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.026','municipio':'Altamira'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.078','municipio':'Baraya'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.132','municipio':'Campoalegre'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.206','municipio':'Colombia'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.244','municipio':'Elías'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.298','municipio':'Garzón'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.306','municipio':'Gigante'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.319','municipio':'Guadalupe'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.349','municipio':'Hobo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.357','municipio':'Iquira'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.359','municipio':'Isnos'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.378','municipio':'La Argentina'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.396','municipio':'La Plata'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.483','municipio':'Nátaga'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.503','municipio':'Oporapa'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.518','municipio':'Paicol'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.524','municipio':'Palermo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.53','municipio':'Palestina'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.548','municipio':'Pital'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.551','municipio':'Pitalito'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.615','municipio':'Rivera'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.66','municipio':'Saladoblanco'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.676','municipio':'Santa María'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.77','municipio':'Suaza'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.791','municipio':'Tarqui'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.797','municipio':'Tesalia'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.799','municipio':'Tello'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.801','municipio':'Teruel'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.807','municipio':'Timaná'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.872','municipio':'Villavieja'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.885','municipio':'Yaguará'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.001','municipio':'Riohacha'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.035','municipio':'Albania'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.078','municipio':'Barrancas'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.09','municipio':'Dibula'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.098','municipio':'Distracción'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.11','municipio':'El Molino'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.279','municipio':'Fonseca'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.378','municipio':'Hatonuevo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.43','municipio':'Maicao'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.56','municipio':'Manaure'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.847','municipio':'Uribia'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.855','municipio':'Urumita'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.874','municipio':'Villanueva'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.001','municipio':'Santa Marta'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.03','municipio':'Algarrobo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.053','municipio':'Aracataca'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.058','municipio':'Ariguaní'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.161','municipio':'Cerro San Antonio'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.17','municipio':'Chivolo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.205','municipio':'Concordia'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.245','municipio':'El Banco'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.258','municipio':'El Piñon'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.268','municipio':'El Retén'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.288','municipio':'Fundación'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.318','municipio':'Guamal'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.46','municipio':'Nueva Granada'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.541','municipio':'Pedraza'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.551','municipio':'Pivijay'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.555','municipio':'Plato'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.605','municipio':'Remolino'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.675','municipio':'Salamina'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.703','municipio':'San Zenón'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.707','municipio':'Santa Ana'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.745','municipio':'Sitionuevo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.798','municipio':'Tenerife'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.96','municipio':'Zapayán'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.98','municipio':'Zona Bananera'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.001','municipio':'Villavicencio'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.006','municipio':'Acacias'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.124','municipio':'Cabuyaro'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.223','municipio':'Cubarral'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.226','municipio':'Cumaral'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.245','municipio':'El Calvario'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.251','municipio':'El Castillo'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.27','municipio':'El Dorado'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.313','municipio':'Granada'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.318','municipio':'Guamal'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.325','municipio':'Mapiripán'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.33','municipio':'Mesetas'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.35','municipio':'La Macarena'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.4','municipio':'Lejanías'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.45','municipio':'Puerto Concordia'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.568','municipio':'Puerto Gaitán'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.573','municipio':'Puerto López'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.577','municipio':'Puerto Lleras'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.59','municipio':'Puerto Rico'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.606','municipio':'Restrepo'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.686','municipio':'San Juanito'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.689','municipio':'San Martín'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.711','municipio':'Vista Hermosa'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.001','municipio':'Pasto'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.019','municipio':'Albán'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.022','municipio':'Aldana'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.036','municipio':'Ancuyá'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.079','municipio':'Barbacoas'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.203','municipio':'Colón'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.207','municipio':'Consaca'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.21','municipio':'Contadero'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.215','municipio':'Córdoba'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.224','municipio':'Cuaspud'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.227','municipio':'Cumbal'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.233','municipio':'Cumbitara'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.25','municipio':'El Charco'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.254','municipio':'El Peñol'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.256','municipio':'El Rosario'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.26','municipio':'El Tambo'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.287','municipio':'Funes'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.317','municipio':'Guachucal'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.32','municipio':'Guaitarilla'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.323','municipio':'Gualmatán'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.352','municipio':'Iles'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.354','municipio':'Imués'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.356','municipio':'Ipiales'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.378','municipio':'La Cruz'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.381','municipio':'La Florida'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.385','municipio':'La Llanada'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.39','municipio':'La Tola'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.399','municipio':'La Unión'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.405','municipio':'Leiva'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.411','municipio':'Linares'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.418','municipio':'Los Andes'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.427','municipio':'Magüí'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.435','municipio':'Mallama'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.473','municipio':'Mosquera'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.48','municipio':'Nariño'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.49','municipio':'Olaya Herrera'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.506','municipio':'Ospina'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.52','municipio':'Francisco Pizarro'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.54','municipio':'Policarpa'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.56','municipio':'Potosí'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.565','municipio':'Providencia'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.573','municipio':'Puerres'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.585','municipio':'Pupiales'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.612','municipio':'Ricaurte'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.621','municipio':'Roberto Payán'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.678','municipio':'Samaniego'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.683','municipio':'Sandoná'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.685','municipio':'San Bernardo'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.687','municipio':'San Lorenzo'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.693','municipio':'San Pablo'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.696','municipio':'Santa Bárbara'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.72','municipio':'Sapuyes'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.786','municipio':'Taminango'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.788','municipio':'Tangua'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.838','municipio':'Túquerres'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.885','municipio':'Yacuanquer'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'63','departamento':'Quindío','c_digo_dane_del_municipio':'63.001','municipio':'Armenia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'63','departamento':'Quindío','c_digo_dane_del_municipio':'63.111','municipio':'Buenavista'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'63','departamento':'Quindío','c_digo_dane_del_municipio':'63.19','municipio':'Circasia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'63','departamento':'Quindío','c_digo_dane_del_municipio':'63.212','municipio':'Córdoba'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'63','departamento':'Quindío','c_digo_dane_del_municipio':'63.272','municipio':'Filandia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'63','departamento':'Quindío','c_digo_dane_del_municipio':'63.401','municipio':'La Tebaida'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'63','departamento':'Quindío','c_digo_dane_del_municipio':'63.47','municipio':'Montenegro'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'63','departamento':'Quindío','c_digo_dane_del_municipio':'63.548','municipio':'Pijao'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'63','departamento':'Quindío','c_digo_dane_del_municipio':'63.594','municipio':'Quimbaya'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'63','departamento':'Quindío','c_digo_dane_del_municipio':'63.69','municipio':'Salento'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.001','municipio':'Pereira'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.045','municipio':'Apía'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.075','municipio':'Balboa'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.17','municipio':'Dosquebradas'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.318','municipio':'Guática'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.383','municipio':'La Celia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.4','municipio':'La Virginia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.44','municipio':'Marsella'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.456','municipio':'Mistrató'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.572','municipio':'Pueblo Rico'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.594','municipio':'Quinchía'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.687','municipio':'Santuario'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.001','municipio':'Bucaramanga'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.013','municipio':'Aguada'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.02','municipio':'Albania'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.051','municipio':'Aratoca'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.077','municipio':'Barbosa'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.079','municipio':'Barichara'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.081','municipio':'Barrancabermeja'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.092','municipio':'Betulia'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.101','municipio':'Bolívar'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.121','municipio':'Cabrera'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.132','municipio':'California'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.152','municipio':'Carcasí'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.16','municipio':'Cepitá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.162','municipio':'Cerrito'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.167','municipio':'Charalá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.169','municipio':'Charta'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.179','municipio':'Chipatá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.19','municipio':'Cimitarra'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.207','municipio':'Concepción'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.209','municipio':'Confines'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.211','municipio':'Contratación'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.217','municipio':'Coromoro'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.229','municipio':'Curití'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.245','municipio':'El Guacamayo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.255','municipio':'El Playón'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.264','municipio':'Encino'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.266','municipio':'Enciso'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.271','municipio':'Florián'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.276','municipio':'Floridablanca'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.296','municipio':'Galán'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.298','municipio':'Gambita'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.307','municipio':'Girón'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.318','municipio':'Guaca'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.32','municipio':'Guadalupe'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.322','municipio':'Guapotá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.324','municipio':'Guavatá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.327','municipio':'Güepsa'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.368','municipio':'Jesús María'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.37','municipio':'Jordán'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.377','municipio':'La Belleza'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.385','municipio':'Landázuri'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.397','municipio':'La Paz'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.406','municipio':'Lebríja'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.418','municipio':'Los Santos'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.425','municipio':'Macaravita'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.432','municipio':'Málaga'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.444','municipio':'Matanza'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.464','municipio':'Mogotes'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.468','municipio':'Molagavita'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.498','municipio':'Ocamonte'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.5','municipio':'Oiba'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.502','municipio':'Onzaga'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.522','municipio':'Palmar'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.533','municipio':'Páramo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.547','municipio':'Piedecuesta'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.549','municipio':'Pinchote'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.572','municipio':'Puente Nacional'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.615','municipio':'Rionegro'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.669','municipio':'San Andrés'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.679','municipio':'San Gil'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.682','municipio':'San Joaquín'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.686','municipio':'San Miguel'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.705','municipio':'Santa Bárbara'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.745','municipio':'Simacota'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.755','municipio':'Socorro'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.77','municipio':'Suaita'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.773','municipio':'Sucre'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.78','municipio':'Suratá'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.82','municipio':'Tona'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.861','municipio':'Vélez'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.867','municipio':'Vetas'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.872','municipio':'Villanueva'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.895','municipio':'Zapatoca'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.001','municipio':'Sincelejo'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.11','municipio':'Buenavista'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.124','municipio':'Caimito'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.204','municipio':'Coloso'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.221','municipio':'Coveñas'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.23','municipio':'Chalán'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.233','municipio':'El Roble'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.235','municipio':'Galeras'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.265','municipio':'Guaranda'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.4','municipio':'La Unión'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.418','municipio':'Los Palmitos'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.429','municipio':'Majagual'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.473','municipio':'Morroa'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.508','municipio':'Ovejas'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.523','municipio':'Palmito'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.678','municipio':'San Benito Abad'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.708','municipio':'San Marcos'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.713','municipio':'San Onofre'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.717','municipio':'San Pedro'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.771','municipio':'Sucre'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.823','municipio':'Tolú Viejo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.024','municipio':'Alpujarra'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.026','municipio':'Alvarado'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.03','municipio':'Ambalema'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.055','municipio':'Armero'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.067','municipio':'Ataco'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.124','municipio':'Cajamarca'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.168','municipio':'Chaparral'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.2','municipio':'Coello'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.217','municipio':'Coyaima'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.226','municipio':'Cunday'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.236','municipio':'Dolores'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.268','municipio':'Espinal'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.27','municipio':'Falan'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.275','municipio':'Flandes'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.283','municipio':'Fresno'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.319','municipio':'Guamo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.347','municipio':'Herveo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.349','municipio':'Honda'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.352','municipio':'Icononzo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.443','municipio':'Mariquita'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.449','municipio':'Melgar'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.461','municipio':'Murillo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.483','municipio':'Natagaima'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.504','municipio':'Ortega'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.52','municipio':'Palocabildo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.547','municipio':'Piedras'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.555','municipio':'Planadas'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.563','municipio':'Prado'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.585','municipio':'Purificación'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.616','municipio':'Rio Blanco'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.622','municipio':'Roncesvalles'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.624','municipio':'Rovira'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.671','municipio':'Saldaña'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.686','municipio':'Santa Isabel'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.861','municipio':'Venadillo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.87','municipio':'Villahermosa'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.873','municipio':'Villarrica'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'81','departamento':'Arauca','c_digo_dane_del_municipio':'81.065','municipio':'Arauquita'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'81','departamento':'Arauca','c_digo_dane_del_municipio':'81.22','municipio':'Cravo Norte'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'81','departamento':'Arauca','c_digo_dane_del_municipio':'81.3','municipio':'Fortul'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'81','departamento':'Arauca','c_digo_dane_del_municipio':'81.591','municipio':'Puerto Rondón'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'81','departamento':'Arauca','c_digo_dane_del_municipio':'81.736','municipio':'Saravena'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'81','departamento':'Arauca','c_digo_dane_del_municipio':'81.794','municipio':'Tame'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'81','departamento':'Arauca','c_digo_dane_del_municipio':'81.001','municipio':'Arauca'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.001','municipio':'Yopal'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.01','municipio':'Aguazul'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.015','municipio':'Chámeza'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.125','municipio':'Hato Corozal'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.136','municipio':'La Salina'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.162','municipio':'Monterrey'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.263','municipio':'Pore'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.279','municipio':'Recetor'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.3','municipio':'Sabanalarga'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.315','municipio':'Sácama'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.41','municipio':'Tauramena'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.43','municipio':'Trinidad'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.44','municipio':'Villanueva'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'86','departamento':'Putumayo','c_digo_dane_del_municipio':'86.001','municipio':'Mocoa'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'86','departamento':'Putumayo','c_digo_dane_del_municipio':'86.219','municipio':'Colón'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'86','departamento':'Putumayo','c_digo_dane_del_municipio':'86.32','municipio':'Orito'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'86','departamento':'Putumayo','c_digo_dane_del_municipio':'86.569','municipio':'Puerto Caicedo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'86','departamento':'Putumayo','c_digo_dane_del_municipio':'86.571','municipio':'Puerto Guzmán'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'86','departamento':'Putumayo','c_digo_dane_del_municipio':'86.573','municipio':'Leguízamo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'86','departamento':'Putumayo','c_digo_dane_del_municipio':'86.749','municipio':'Sibundoy'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'86','departamento':'Putumayo','c_digo_dane_del_municipio':'86.755','municipio':'San Francisco'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'86','departamento':'Putumayo','c_digo_dane_del_municipio':'86.757','municipio':'San Miguel'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'86','departamento':'Putumayo','c_digo_dane_del_municipio':'86.76','municipio':'Santiago'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'91','departamento':'Amazonas','c_digo_dane_del_municipio':'91.001','municipio':'Leticia'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'91','departamento':'Amazonas','c_digo_dane_del_municipio':'91.263','municipio':'El Encanto'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'91','departamento':'Amazonas','c_digo_dane_del_municipio':'91.405','municipio':'La Chorrera'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'91','departamento':'Amazonas','c_digo_dane_del_municipio':'91.407','municipio':'La Pedrera'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'91','departamento':'Amazonas','c_digo_dane_del_municipio':'91.43','municipio':'La Victoria'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'91','departamento':'Amazonas','c_digo_dane_del_municipio':'91.536','municipio':'Puerto Arica'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'91','departamento':'Amazonas','c_digo_dane_del_municipio':'91.54','municipio':'Puerto Nariño'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'91','departamento':'Amazonas','c_digo_dane_del_municipio':'91.669','municipio':'Puerto Santander'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'91','departamento':'Amazonas','c_digo_dane_del_municipio':'91.798','municipio':'Tarapacá'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'94','departamento':'Guainía','c_digo_dane_del_municipio':'94.001','municipio':'Inírida'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'94','departamento':'Guainía','c_digo_dane_del_municipio':'94.343','municipio':'Barranco Minas'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'94','departamento':'Guainía','c_digo_dane_del_municipio':'94.663','municipio':'Mapiripana'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'94','departamento':'Guainía','c_digo_dane_del_municipio':'94.883','municipio':'San Felipe'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'94','departamento':'Guainía','c_digo_dane_del_municipio':'94.884','municipio':'Puerto Colombia'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'94','departamento':'Guainía','c_digo_dane_del_municipio':'94.885','municipio':'La Guadalupe'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'94','departamento':'Guainía','c_digo_dane_del_municipio':'94.886','municipio':'Cacahual'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'94','departamento':'Guainía','c_digo_dane_del_municipio':'94.887','municipio':'Pana Pana'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'97','departamento':'Vaupés','c_digo_dane_del_municipio':'97.001','municipio':'Mitú'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'97','departamento':'Vaupés','c_digo_dane_del_municipio':'97.161','municipio':'Carurú'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'97','departamento':'Vaupés','c_digo_dane_del_municipio':'97.666','municipio':'Taraira'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'97','departamento':'Vaupés','c_digo_dane_del_municipio':'97.777','municipio':'Papunahua'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'97','departamento':'Vaupés','c_digo_dane_del_municipio':'97.889','municipio':'Yavaraté'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'97','departamento':'Vaupés','c_digo_dane_del_municipio':'97.511','municipio':'Pacoa'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'94','departamento':'Guainía','c_digo_dane_del_municipio':'94.888','municipio':'Morichal'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'99','departamento':'Vichada','c_digo_dane_del_municipio':'99.001','municipio':'Puerto Carreño'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'99','departamento':'Vichada','c_digo_dane_del_municipio':'99.524','municipio':'La Primavera'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'99','departamento':'Vichada','c_digo_dane_del_municipio':'99.624','municipio':'Santa Rosalía'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'99','departamento':'Vichada','c_digo_dane_del_municipio':'99.773','municipio':'Cumaribo'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'18','departamento':'Caquetá','c_digo_dane_del_municipio':'18.61','municipio':'San José del Fragua'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.11','municipio':'Barranca de Upía'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.524','municipio':'Palmas del Socorro'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.662','municipio':'San Juan de Río Seco'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.372','municipio':'Juan de Acosta'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.287','municipio':'Fuente de Oro'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.325','municipio':'San Luis de Gaceno'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.25','municipio':'El Litoral del San Juan'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.843','municipio':'Villa de San Diego de Ubate'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.074','municipio':'Barranco de Loba'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.816','municipio':'Togüí'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.688','municipio':'Santa Rosa del Sur'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.135','municipio':'El Cantón del San Pablo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.407','municipio':'Villa de Leyva'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.692','municipio':'San Sebastián de Buenavista'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.537','municipio':'Paz de Río'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.3','municipio':'Hatillo de Loba'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.66','municipio':'Sabanas de San Angel'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'95','departamento':'Guaviare','c_digo_dane_del_municipio':'95.015','municipio':'Calamar'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.614','municipio':'Río de Oro'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.665','municipio':'San Pedro de Uraba'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'95','departamento':'Guaviare','c_digo_dane_del_municipio':'95.001','municipio':'San José del Guaviare'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.693','municipio':'Santa Rosa de Viterbo'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.698','municipio':'Santander de Quilichao'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'95','departamento':'Guaviare','c_digo_dane_del_municipio':'95.2','municipio':'Miraflores'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.042','municipio':'Santafé de Antioquia'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.68','municipio':'San Carlos de Guaroa'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.52','municipio':'Palmar de Varela'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.686','municipio':'Santa Rosa de Osos'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.647','municipio':'San Andrés de Cuerquía'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.854','municipio':'Valle de San Juan'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.689','municipio':'San Vicente de Chucurí'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.684','municipio':'San José de Miranda'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'88','departamento':'Archipiélago de San Andrés, Providencia y Santa Catalina','c_digo_dane_del_municipio':'88.564','municipio':'Providencia'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.682','municipio':'Santa Rosa de Cabal'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.328','municipio':'Guayabal de Siquima'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'18','departamento':'Caquetá','c_digo_dane_del_municipio':'18.094','municipio':'Belén de Los Andaquies'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'85','departamento':'Casanare','c_digo_dane_del_municipio':'85.25','municipio':'Paz de Ariporo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.72','municipio':'Santa Helena del Opón'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.681','municipio':'San Pablo de Borbur'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.42','municipio':'La Jagua del Pilar'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'20','departamento':'Cesar','c_digo_dane_del_municipio':'20.4','municipio':'La Jagua de Ibirico'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.742','municipio':'San Luis de Sincé'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.667','municipio':'San Luis de Gaceno'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.244','municipio':'El Carmen de Bolívar'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.245','municipio':'El Carmen de Atrato'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.702','municipio':'San Juan de Betulia'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'47','departamento':'Magdalena','c_digo_dane_del_municipio':'47.545','municipio':'Pijiño del Carmen'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.873','municipio':'Vigía del Fuerte'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.667','municipio':'San Martín de Loba'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.03','municipio':'Altos del Rosario'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.148','municipio':'Carmen de Apicala'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.645','municipio':'San Antonio del Tequendama'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.655','municipio':'Sabana de Torres'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'95','departamento':'Guaviare','c_digo_dane_del_municipio':'95.025','municipio':'El Retorno'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.682','municipio':'San José de Uré'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.694','municipio':'San Pedro de Cartago'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'8','departamento':'Atlántico','c_digo_dane_del_municipio':'8.137','municipio':'Campo de La Cruz'}
,{'region':'Región Llano','c_digo_dane_del_departamento':'50','departamento':'Meta','c_digo_dane_del_municipio':'50.683','municipio':'San Juan de Arama'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.658','municipio':'San José de La Montaña'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'18','departamento':'Caquetá','c_digo_dane_del_municipio':'18.15','municipio':'Cartagena del Chairá'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.66','municipio':'San José del Palmar'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.001','municipio':'Agua de Dios'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.655','municipio':'San Jacinto del Cauca'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'41','departamento':'Huila','c_digo_dane_del_municipio':'41.668','municipio':'San Agustín'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'52','departamento':'Nariño','c_digo_dane_del_municipio':'52.258','municipio':'El Tablón de Gómez'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'88','departamento':'Archipiélago de San Andrés, Providencia y Santa Catalina','c_digo_dane_del_municipio':'88.001','municipio':'San Andrés'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.664','municipio':'San José de Pare'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'86','departamento':'Putumayo','c_digo_dane_del_municipio':'86.865','municipio':'Valle de Guamez'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.67','municipio':'San Pablo de Borbur'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'70','departamento':'Sucre','c_digo_dane_del_municipio':'70.82','municipio':'Santiago de Tolú'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'11','departamento':'Bogotá D.C.','c_digo_dane_del_municipio':'11.001','municipio':'Bogotá D.C.'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.154','municipio':'Carmen de Carupa'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.189','municipio':'Ciénaga de Oro'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.659','municipio':'San Juan de Urabá'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'44','departamento':'La Guajira','c_digo_dane_del_municipio':'44.65','municipio':'San Juan del Cesar'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.235','municipio':'El Carmen de Chucurí'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.148','municipio':'El Carmen de Viboral'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'66','departamento':'Risaralda','c_digo_dane_del_municipio':'66.088','municipio':'Belén de Umbría'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'27','departamento':'Chocó','c_digo_dane_del_municipio':'27.086','municipio':'Belén de Bajira'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.855','municipio':'Valle de San José'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.678','municipio':'San Luis'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.676','municipio':'San Miguel de Sema'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'73','departamento':'Tolima','c_digo_dane_del_municipio':'73.675','municipio':'San Antonio'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.673','municipio':'San Benito'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'25','departamento':'Cundinamarca','c_digo_dane_del_municipio':'25.862','municipio':'Vergara'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'23','departamento':'Córdoba','c_digo_dane_del_municipio':'23.678','municipio':'San Carlos'}
,{'region':'Región Centro Sur','c_digo_dane_del_departamento':'91','departamento':'Amazonas','c_digo_dane_del_municipio':'91.53','municipio':'Puerto Alegría'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'68','departamento':'Santander','c_digo_dane_del_municipio':'68.344','municipio':'Hato'}
,{'region':'Región Caribe','c_digo_dane_del_departamento':'13','departamento':'Bolívar','c_digo_dane_del_municipio':'13.654','municipio':'San Jacinto'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'19','departamento':'Cauca','c_digo_dane_del_municipio':'19.693','municipio':'San Sebastián'}
,{'region':'Región Eje Cafetero - Antioquia','c_digo_dane_del_departamento':'5','departamento':'Antioquia','c_digo_dane_del_municipio':'5.649','municipio':'San Carlos'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'15','departamento':'Boyacá','c_digo_dane_del_municipio':'15.837','municipio':'Tuta'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'54','departamento':'Norte de Santander','c_digo_dane_del_municipio':'54.743','municipio':'Silos'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'54','departamento':'Norte de Santander','c_digo_dane_del_municipio':'54.125','municipio':'Cácota'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'76','departamento':'Valle del Cauca','c_digo_dane_del_municipio':'76.25','municipio':'El Dovio'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'54','departamento':'Norte de Santander','c_digo_dane_del_municipio':'54.82','municipio':'Toledo'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'76','departamento':'Valle del Cauca','c_digo_dane_del_municipio':'76.622','municipio':'Roldanillo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'54','departamento':'Norte de Santander','c_digo_dane_del_municipio':'54.48','municipio':'Mutiscua'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'76','departamento':'Valle del Cauca','c_digo_dane_del_municipio':'76.054','municipio':'Argelia'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'54','departamento':'Norte de Santander','c_digo_dane_del_municipio':'54.261','municipio':'El Zulia'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'54','departamento':'Norte de Santander','c_digo_dane_del_municipio':'54.66','municipio':'Salazar'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'76','departamento':'Valle del Cauca','c_digo_dane_del_municipio':'76.736','municipio':'Sevilla'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'76','departamento':'Valle del Cauca','c_digo_dane_del_municipio':'76.895','municipio':'Zarzal'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'54','departamento':'Norte de Santander','c_digo_dane_del_municipio':'54.223','municipio':'Cucutilla'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'76','departamento':'Valle del Cauca','c_digo_dane_del_municipio':'76.248','municipio':'El Cerrito'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'76','departamento':'Valle del Cauca','c_digo_dane_del_municipio':'76.147','municipio':'Cartago'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'76','departamento':'Valle del Cauca','c_digo_dane_del_municipio':'76.122','municipio':'Caicedonia'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'54','departamento':'Norte de Santander','c_digo_dane_del_municipio':'54.553','municipio':'Puerto Santander'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'54','departamento':'Norte de Santander','c_digo_dane_del_municipio':'54.313','municipio':'Gramalote'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'76','departamento':'Valle del Cauca','c_digo_dane_del_municipio':'76.246','municipio':'El Cairo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'54','departamento':'Norte de Santander','c_digo_dane_del_municipio':'54.25','municipio':'El Tarra'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'76','departamento':'Valle del Cauca','c_digo_dane_del_municipio':'76.4','municipio':'La Unión'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'76','departamento':'Valle del Cauca','c_digo_dane_del_municipio':'76.606','municipio':'Restrepo'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'54','departamento':'Norte de Santander','c_digo_dane_del_municipio':'54.8','municipio':'Teorama'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'76','departamento':'Valle del Cauca','c_digo_dane_del_municipio':'76.233','municipio':'Dagua'}
,{'region':'Región Centro Oriente','c_digo_dane_del_departamento':'54','departamento':'Norte de Santander','c_digo_dane_del_municipio':'54.051','municipio':'Arboledas'}
,{'region':'Región Pacífico','c_digo_dane_del_departamento':'76','departamento':'Valle del Cauca','c_digo_dane_del_municipio':'76.318','municipio':'Guacarí'}]";
        
            return json;    
        }
    }


    
}
