require 'test_helper'

class DmnguonsControllerTest < ActionController::TestCase
  setup do
    @dmnguon = dmnguons(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmnguons)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmnguon" do
    assert_difference('Dmnguon.count') do
      post :create, dmnguon: { nhom: @dmnguon.nhom, stt: @dmnguon.stt, ten: @dmnguon.ten }
    end

    assert_redirected_to dmnguon_path(assigns(:dmnguon))
  end

  test "should show dmnguon" do
    get :show, id: @dmnguon
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmnguon
    assert_response :success
  end

  test "should update dmnguon" do
    patch :update, id: @dmnguon, dmnguon: { nhom: @dmnguon.nhom, stt: @dmnguon.stt, ten: @dmnguon.ten }
    assert_redirected_to dmnguon_path(assigns(:dmnguon))
  end

  test "should destroy dmnguon" do
    assert_difference('Dmnguon.count', -1) do
      delete :destroy, id: @dmnguon
    end

    assert_redirected_to dmnguons_path
  end
end
