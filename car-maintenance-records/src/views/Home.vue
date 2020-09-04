<template>
  <div class="home">
    <image-gallery :arrayOfImgObj="arrayOfImgObj" />
    <car-specs :carSpecs="carSpecs" />
    <maintenance-records :records="records" />
  </div>
</template>

<script>
import ImageGallery from '@/components/ImageGallery.vue'
import CarSpecs from '@/components/CarSpecs.vue'
import MaintenanceRecords from '@/components/MaintenanceRecords.vue'

export default {
  name: 'Home',
  components: {
    ImageGallery,
    CarSpecs,
    MaintenanceRecords
  },
  data() {
    return {
      arrayOfImgObj: [
        {
          carId: 1,
          src: 'https://live.staticflickr.com/1083/1112654629_cfd5ba8751_b.jpg',
          alt: 'Yellow 2003 Mini Cooper S hood from front right'
        },
        {
          carId: 1,
          src: 'https://live.staticflickr.com/1392/1171507559_a36f1700e4_b.jpg',
          alt: 'Yellow 2003 Mini Cooper S from side'
        },
        {
          carId: 1,
          src: 'https://live.staticflickr.com/1253/1172410372_3275d2941c_b.jpg',
          alt: 'Yellow 2003 Mini Cooper S front view with doors open'
        },
      ],
      carSpecs: {
        carId: 1,
        year: '2003',
        make: 'Mini',
        model: 'Cooper S',
        VIN: 'WDD1760522J639541',
        color: 'Yellow',
        transmission: '6-Speed Manual',
        wheelSize: '16" diameter, 6.5" width',
        baseEngineSize: '1.6 L',
        oil: {
            type: '5W 30 Conventional',
            capacity: '4.8 Qts'
        }
      },
      records: [
        {
          recordId: 1,
          carId: 1,
          date: '2019-03-20',
          mileage: '144,295',
          description: 'Changed oil and filter. Used Moto 1 5W 30 High Mileage Conventional.'
        },
        {
          recordId: 2,
          carId: 1,
          date: '2019-09-12',
          mileage: '146,729',
          description: 'Changed oil and filter. Used Moto 1 5W 30 High Mileage Conventional.'
        },
        {
          recordId: 3,
          carId: 1,
          date: '2019-10-02',
          mileage: '147,101',
          description: 'Replaced two front headlights.'
        },
        {
          recordId: 4,
          carId: 1,
          date: '2020-01-21',
          mileage: '150,005',
          description: 'Changed oil and filter. Used Moto 1 5W 30 High Mileage Conventional. Replaced both rear brake pads.'
        },
        {
          recordId: 5,
          carId: 1,
          date: '2020-04-12',
          mileage: '154,112',
          description: 'Changed oil and filter. Used Moto 1 5W 30 High Mileage Conventional.'
        },
      ]
    }
  }
}
</script>