<template>
  <div class="home">
    <load-spinner v-if="!isImgLoaded" />
    <image-gallery :arrayOfImgObj="arrayOfImgObj" v-if="isImgLoaded" />

    <load-spinner v-if="!isSpecsLoaded" />
    <car-specs :carSpecs="carSpecs" v-if="isSpecsLoaded"/>

    <record-form :carIdProp="carId" />

    <load-spinner v-if="!isRecordsLoaded" />
    <maintenance-records :records="records" v-if="isRecordsLoaded" />

  </div>
</template>

<script>
import ImageGallery from '@/components/ImageGallery.vue'
import CarSpecs from '@/components/CarSpecs.vue'
import MaintenanceRecords from '@/components/MaintenanceRecords.vue'
import api from '@/services/ApiService.js'
import LoadSpinner from '@/components/LoadSpinner.vue'
import RecordForm from '@/components/RecordForm.vue'

export default {
  name: 'Home',
  components: {
    ImageGallery,
    CarSpecs,
    MaintenanceRecords,
    LoadSpinner,
    RecordForm
  },
  data() {
    return {
      arrayOfImgObj: [],
      carSpecs: {},
      records: [],
      isImgLoaded: false,
      isSpecsLoaded: false,
      isRecordsLoaded: false,
      // Todo: hardcoded for now
      carId: 1,
    } 
  },
  methods: {
    loadContent(){
      this.isLoading = false;
      // TODO: carID is hardcoded for now
      api.getSpecs(1).then(r =>{
        if (r.status === 200){
          this.carSpecs = r.data;
          this.isSpecsLoaded = true;
        }
      }) // TODO: do something here

      api.getPics(1).then(r => {
        if (r.status === 200){
          this.arrayOfImgObj = r.data;
          this.isImgLoaded = true;
        }
      }) // do something here

      api.getRecords(1).then(r => {
        if (r.status === 200){
          this.records = r.data;
          this.isRecordsLoaded = true;
        }
      }) // do something here

    }
  },
  created() {
      this.loadContent()
    }
}
</script>

<style scoped>
.btn {
  margin: 1.5rem;
}
</style>