<template>
  <section id="car-specs" class="container">
    <h1>{{carSpecs.yearMade}} {{carSpecs.make}} {{carSpecs.model}} Maintenance Records</h1>
    <div class="container">
        <dl class="row">
            <dt class="col-2">Color</dt>
            <dd class="col-4">{{carSpecs.color}}</dd>

            <dt class="col-2 text-truncate">Transmission</dt>
            <dd class="col-4">{{carSpecs.transmission}}</dd>
        </dl>
        <dl class="row">
            <dt class="col-2">Engine Size</dt>
            <dd class="col-4">{{carSpecs.baseEngineSize}}</dd>

            <dt class="col-2">Wheel Size</dt>
            <dd class="col-4">{{carSpecs.wheelSize}}</dd>
        </dl>
    </div>
  </section>
</template>

<script>
export default {
    data() {
        return {
            
        }
    },
    props: {
        carSpecs: Object
    }
}
</script>

<style scoped>
#car-specs h1 {
    margin: 1rem auto 2rem auto;
}

</style>