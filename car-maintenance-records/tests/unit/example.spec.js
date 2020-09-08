import { expect } from 'chai'
import { mount } from '@vue/test-utils'
import ImageGallery from '@/components/ImageGallery.vue'

const imgGallery = mount(ImageGallery, {
  propsData: {
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
})

describe('Image changes on click', () => {
  
  
  it('Should change the image moving right', () => {
    const wrapper = imgGallery.find('div.img-move-right')
    //console.debug(wrapper)
    const wrapperImgFirst = imgGallery.find('img')
    //console.debug(wrapperImgFirst)
    wrapper.trigger('click')
    const wrapperImgSecond = imgGallery.find('img')
    expect(wrapperImgFirst.attributes('src')).to.not.equal(wrapperImgSecond.attributes('src'))
  })

  it('Should change the image moving left', () => {
    imgGallery.setData({imgIndex: 1})
    const wrapper = imgGallery.find('div.img-move-left')
    const wrapperImgFirst = imgGallery.find('img')
    wrapper.trigger('click')
    const wrapperImgSecond = imgGallery.find('img')
    expect(wrapperImgFirst.attributes('src')).to.not.equal(wrapperImgSecond.attributes('src'))
  })

  it('Should not change the image moving left if on first img', () => {
    const wrapper = imgGallery.find('div.img-move-left')
    const wrapperImgFirst = imgGallery.find('img')
    wrapper.trigger('click')
    const wrapperImgSecond = imgGallery.find('img')
    expect(wrapperImgFirst.attributes('src')).to.equal(wrapperImgSecond.attributes('src'))
  })
})
