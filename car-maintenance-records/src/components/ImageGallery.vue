<template>
  <div class="img-gallery">
      <div class="img-move-left" @click="imgMoveLeft()">
          &lt;
      </div>
      <div id="img-box">
          <img src="https://live.staticflickr.com/1083/1112654629_cfd5ba8751_b.jpg" alt="Yellow 2003 Mini Cooper S hood from front right" v-if="imgIndex === 0" />
          <img src="https://live.staticflickr.com/1392/1171507559_a36f1700e4_b.jpg" alt="Yellow 2003 Mini Cooper S from side" v-if="imgIndex === 1" />
          <img src="https://live.staticflickr.com/1253/1172410372_3275d2941c_b.jpg" alt="Yellow 2003 Mini Cooper S front view with doors open" v-if="imgIndex === 2" />
      </div>
      <div class="img-move-right" @click="imgMoveRight()">
          &gt;
      </div>
  </div>
</template>

<script>
export default {
    data() {
        return {
            imgIndex: 0
        }
    },
    methods: {
        imgMoveLeft() {
            if (this.imgIndex > 0) {
                this.imgIndex--;
            }
        },
        imgMoveRight() {
            //  TODO: This is hardcoded in for now
            if (this.imgIndex < 2) {
                this.imgIndex++;
            }
        }
    }
}
</script>

<style scoped>
img {
    height: 300px;
}
.img-gallery {
    width: 500px;
    height: 300px;
    background-color: grey;
    border: 2px solid black;
    border-radius: 5px;
    padding: 0px;
    display: flex;
    justify-content: space-evenly;
    align-content: space-around;
    margin: 0px auto 25px auto;
}
.img-move-left, .img-move-right {
    color: black;
    font-size: 2em;
    width: 50px;
    display: flex;
    flex-direction: column;
    justify-content: center;
    cursor: pointer;
}
</style>