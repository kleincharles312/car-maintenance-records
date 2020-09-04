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
import api from '@/services/ApiService.js'

export default {
  name: 'Home',
  components: {
    ImageGallery,
    CarSpecs,
    MaintenanceRecords
  },
  data() {
    return {
      arrayOfImgObj: [],
      carSpecs: {},
      records: []
    } 
  },
  created() {
      // TODO: carID is hardcoded for now
      api.getSpecs(1).then(r =>{
        if (r.status === 200){
          this.carSpecs = r.data;
        }
      }) // do something here

      api.getPics(1).then(r => {
        if (r.status === 200){
          this.arrayOfImgObj = r.data;
        }
      }) // do something here

      api.getRecords(1).then(r => {
        if (r.status === 200){
          this.records = r.data;
        }
      }) // do something here
    }
}
</script>