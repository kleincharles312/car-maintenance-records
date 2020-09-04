<template>
  <div class="home">
    <image-gallery :arrayOfImgObj="arrayOfImgObj" />
    <car-specs />
  </div>
</template>

<script>
import ImageGallery from '@/components/ImageGallery.vue'
import CarSpecs from '@/components/CarSpecs.vue'

export default {
  name: 'Home',
  components: {
    ImageGallery,
    CarSpecs
  },
  data() {
    return {
      arrayOfImgObj: [
        {
          src: 'https://live.staticflickr.com/1083/1112654629_cfd5ba8751_b.jpg',
          alt: 'Yellow 2003 Mini Cooper S hood from front right'
        },
        {
          src: 'https://live.staticflickr.com/1392/1171507559_a36f1700e4_b.jpg',
          alt: 'Yellow 2003 Mini Cooper S from side'
        },
        {
          src: 'https://live.staticflickr.com/1253/1172410372_3275d2941c_b.jpg',
          alt: 'Yellow 2003 Mini Cooper S front view with doors open'
        },
      ]
    }
    
  }
}
</script>
