<template>
  <div class="img-gallery">
      <div class="img-move-left" @click="imgMoveLeft()">
          &lt;
      </div>
      <div class="img-box">
          <img class="img-fluid" :src="displayImg.src" :alt="displayImg.alt" />
          <div class="img-index-dots">
              <div v-for="i in arrayOfImgObj.length"
              :key="i"
              :class="{'index-dot': true, 'active': imgIndex === (i - 1)}"></div>
          </div>
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
    computed: {
        displayImg() {
            return this.arrayOfImgObj[this.imgIndex]
        }
    },
    props: {
        arrayOfImgObj: Array
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
    width: auto;
    height: 100%;
    z-index: 2;
}
.img-gallery {
    max-width: 75%;
    max-height: 400px;
    background-color: rgba(211, 211, 211, 0.507);
    border: 2px solid black;
    border-radius: 5px;
    padding: 0px;
    display: flex;
    justify-content: center;
    margin: 0px auto 25px auto;
    box-shadow: 0 1px 3px rgba(0, 0, 0, 0.5);
}
.img-move-left, .img-move-right {
    color: black;
    font-size: 2em;
    width: 30%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-content: center;
    cursor: pointer;
    z-index: 1;
}
.img-box {
    width: 80%;
    margin: 0px auto;
}
.img-index-dots {
    position: relative;
    bottom: 12px;
    display: flex;
    justify-content: center;
    background-color: rgba(255, 255, 255, 0.274);
}
.index-dot {
    width: 8px;
    height: 8px;
    margin: 2px 5px;
    background-color: rgba(255, 255, 255, 0.801);
    border-radius: 50%;
    z-index: 1;
    box-shadow: inset 1px 1px 1px grey;
}
.active {
    background-color: rgba(0, 0, 0, 0.5);
}
</style>