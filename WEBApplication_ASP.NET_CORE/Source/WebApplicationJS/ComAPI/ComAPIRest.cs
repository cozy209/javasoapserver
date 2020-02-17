using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using WebApplicationJS.Models;

namespace WebApplicationJS.ComAPI
{
    public class ComAPIRest
    {
        #region VARIABLES
        private readonly string _BaseUrl;
        private static readonly string _APIKey = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.e30.atWrWc4h8upVfiER1UMyB6PPQ2V82iF9QGzeP-TrmOM";
        #endregion

        #region Constructeur
        public ComAPIRest(string BASEURL)
        {
            _BaseUrl = BASEURL;
        }
        #endregion

        #region VOL
        #region GET ALL
        public List<VolModel> VolGetALL()
        {
            List<VolModel> LAListe = new List<VolModel>();
            try
            {
                using (HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri(_BaseUrl)
                })
                {
                    client.DefaultRequestHeaders.Add("Authorization", _APIKey);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("Vol/GetAllVol").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<List<VolModel>>(response.Content.ReadAsStringAsync().Result);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return LAListe;
        }
        #endregion

        #region GET ONE
        public VolModel VolGetOne(long ID)
        {
            VolModel LAListe = new VolModel();
            try
            {
                using (HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri(_BaseUrl)
                })
                {
                    client.DefaultRequestHeaders.Add("Authorization", _APIKey);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("Vol/" + ID).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<VolModel>(response.Content.ReadAsStringAsync().Result);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return LAListe;
        }
        #endregion

        #region RESERVE
        public bool VolReserve(long ID, string nom)
        {
            try
            {
                using (HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri(_BaseUrl)
                })
                {
                    client.DefaultRequestHeaders.Add("Authorization", _APIKey);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    using (HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(ID + nom)))
                    {
                        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                        HttpResponseMessage response = client.PutAsync($"Vol/" + ID + "/" + nom, httpContent).Result;
                        return response.IsSuccessStatusCode;
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        #endregion
        #endregion

        #region HOTEL
        #region GET ALL
        public List<HotelModel> HotelGetAll()
        {
            List<HotelModel> LAListe = new List<HotelModel>();
            try
            {
                using (HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri(_BaseUrl)
                })
                {
                    client.DefaultRequestHeaders.Add("Authorization", _APIKey);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("Hotel/GetAllHotel").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<List<HotelModel>>(response.Content.ReadAsStringAsync().Result);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return LAListe;
        }
        #endregion

        #region GET ONE
        public HotelModel HotelGetOne(string ID)
        {
            HotelModel LAListe = new HotelModel();
            try
            {
                using (HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri(_BaseUrl)
                })
                {
                    client.DefaultRequestHeaders.Add("Authorization", _APIKey);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("Hotel/" + ID).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<HotelModel>(response.Content.ReadAsStringAsync().Result);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return LAListe;
        }
        #endregion

        #region Reserve
        public bool HotelReserve(string ID, int nom)
        {
            try
            {
                using (HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri(_BaseUrl)
                })
                {
                    client.DefaultRequestHeaders.Add("Authorization", _APIKey);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    using (HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(ID + nom)))
                    {
                        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                        HttpResponseMessage response = client.PutAsync($"Hotel/" + ID + "/" + nom, httpContent).Result;
                        return response.IsSuccessStatusCode;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        #endregion
        #endregion
    }
}
