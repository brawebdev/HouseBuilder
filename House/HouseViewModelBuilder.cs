﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class HouseViewModelBuilder
    {
        public HouseViewModel houseBuilderVM;

        public HouseViewModelBuilder()
        {
            houseBuilderVM = new HouseViewModel();
        }

        public HouseViewModelBuilder setName(string name)
        {
            houseBuilderVM.Name = name;
            return this;
        }

        public HouseViewModelBuilder setStories(string stories)
        {
            houseBuilderVM.Stories = stories;
            return this;
        }

        public HouseViewModelBuilder setGarage(string garage)
        {
            houseBuilderVM.Garage = garage;
            return this;
        }

        public HouseViewModelBuilder setRooms(int rooms)
        {
            houseBuilderVM.Rooms = rooms;
            return this;
        }

        public HouseViewModelBuilder setBasement(string basement)
        {
            houseBuilderVM.Basement = basement;
            return this;
        }

        public HouseViewModelBuilder setkitchen(string kitchen)
        {
            houseBuilderVM.Kitchen = kitchen;
            return this;
        }

        public HouseViewModelBuilder setBathroomFlooring(string bathroomFlooring)
        {
            houseBuilderVM.BathroomFlooring = bathroomFlooring;
            return this;
        }

        public HouseViewModelBuilder setBedroomFlooring(string bedroomFlooring)
        {
            houseBuilderVM.BedroomFlooring = bedroomFlooring;
            return this;
        }

        public HouseViewModelBuilder setCommonAreaFlooring(string commonAreaFlooring)
        {
            houseBuilderVM.CommonAreaFlooring = commonAreaFlooring;
            return this;
        }

        public HouseViewModel Build()
        {
            return houseBuilderVM;
        }

    }
}
