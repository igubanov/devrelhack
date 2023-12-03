import { DevRelTemplatePage } from './app.po';

describe('DevRel App', function() {
  let page: DevRelTemplatePage;

  beforeEach(() => {
    page = new DevRelTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
